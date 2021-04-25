using ImageMagick;
using SkiaSharp;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BIR.WinForms {
    public partial class Main : Form {

        string[] acceptedExtensions = new string[] { ".jpg", ".png", ".bmp", ".tif", ".jpeg" };
        string srcPath;
        string destPath;
        int targetHeight;
        int targetWidth;
        Common.Enums.ResizeMode resizeMode = Common.Enums.ResizeMode.Contain;
        Common.Enums.CollisionAction collisionAction = Common.Enums.CollisionAction.Skip;

        public Main() {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(srcPath)) { folderPicker.SelectedPath = srcPath; }

            var result = folderPicker.ShowDialog();
            if (result != DialogResult.Cancel) {
                srcPath = folderPicker.SelectedPath;
                lbSourceFiles.Items.Clear();
                lbSourceFiles.DisplayMember = "Name";
                BuildFileTreeRecursive(srcPath);

            }
        }


        private void BuildFileTreeRecursive(string rootPath)
        {
            DirectoryInfo srcFolder = new DirectoryInfo(rootPath);

            foreach (FileInfo fi in srcFolder.GetFiles().Where(fi => acceptedExtensions.Contains(fi.Extension.ToLower())))
            {
                lbSourceFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, FullName = fi.FullName });
            }

            foreach(DirectoryInfo di in srcFolder.GetDirectories())
            {
                BuildFileTreeRecursive(di.FullName);
            }
        }



        private void btnAddToBatch_Click(object sender, EventArgs e) {
            foreach (BIR.Common.Models.ImageReference ir in lbSourceFiles.SelectedItems) {
                lbBatchFiles.Items.Add(ir);
            }
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(destPath)) {
                folderPicker.SelectedPath = destPath;
            }
            else if (!string.IsNullOrWhiteSpace(srcPath)) {
                folderPicker.SelectedPath = srcPath;
            }

            var result = folderPicker.ShowDialog();
            if (result != DialogResult.Cancel) {
                destPath = folderPicker.SelectedPath;
                lblOutputPath.Text = destPath;
            }

        }

        private void btnProcess_Click(object sender, EventArgs e) {
            bool resizeModeSet = false;
            bool collisionActionSet = false;

            if (!Int32.TryParse(txtHeight.Text, out targetHeight) || !(Int32.TryParse(txtWidth.Text, out targetWidth))) {
                MessageBox.Show("Height and Width must be set", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(destPath)) {
                MessageBox.Show("Select a destination path", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (RadioButton rbtn in gbResizeMode.Controls) {
                if (rbtn.Checked) {
                    resizeMode = (Common.Enums.ResizeMode)Convert.ToInt32((rbtn.Tag));
                    resizeModeSet = true;
                }
            }
            if (!resizeModeSet) {
                MessageBox.Show("Resize Mode must be selected", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach (RadioButton rbtn in gbCollisionAction.Controls) {
                if (rbtn.Checked) {
                    collisionAction = (Common.Enums.CollisionAction)Convert.ToInt32((rbtn.Tag));
                    collisionActionSet = true;
                }
            }

            if (!collisionActionSet) {
                MessageBox.Show("Collision Action must be selected", "Error", MessageBoxButtons.OK);
                return;
            }

            if (bwResizeWorker.IsBusy != true) {
                bwResizeWorker.RunWorkerAsync();
            }

        }

        private void lbBatchFiles_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);


            foreach (string file in files) {
                var fi = new FileInfo(file);
                if (acceptedExtensions.Contains(fi.Extension.ToLower())) {
                    lbBatchFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, FullName = fi.FullName });
                }
            }


        }

        private void lbBatchFiles_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void btnClearBatch_Click(object sender, EventArgs e) {
            lbBatchFiles.Items.Clear();
        }

        private void bwResizeWorker_DoWork(object sender, DoWorkEventArgs e) {

            BackgroundWorker worker = sender as BackgroundWorker;

            decimal i = 0;

            foreach (BIR.Common.Models.ImageReference ir in lbBatchFiles.Items) {
                worker.ReportProgress(Convert.ToInt16((++i / lbBatchFiles.Items.Count) * 100));

                if (worker.CancellationPending == true) {
                    e.Cancel = true;
                    break;
                }
                else {
                    try
                    {


                        var workingName = ir.Name;

                        var targetPath = Path.Combine(destPath, ir.FullName.Replace(srcPath + "\\", ""));
                        if (File.Exists(targetPath))
                        {
                            switch (collisionAction)
                            {
                                case Common.Enums.CollisionAction.Skip:
                                    continue;
                                case Common.Enums.CollisionAction.Overwrite:
                                    File.Delete(targetPath);
                                    break;
                                case Common.Enums.CollisionAction.RenameResize:
                                    workingName = DateTime.Now.ToString("yyyyMMddHHmmssff") + "_" + ir.Name;
                                    targetPath = Path.Combine(destPath, workingName);
                                    break;
                                case Common.Enums.CollisionAction.RenameExisting:
                                    var rename = DateTime.Now.ToString("yyyyMMddHHmmssff") + "_" + ir.Name;
                                    var copyPath = Path.Combine(destPath, rename);
                                    File.Move(targetPath, copyPath);
                                    break;
                            }
                        }

                        var targetDir = new FileInfo(targetPath).Directory;
                        if (!targetDir.Exists) { System.IO.Directory.CreateDirectory(targetDir.FullName); }

                        //Check to see if the source file is an heic, if so convert it to a jpeg
                        //ImageMagick Performance was unnaceptable for some reason during the resize process, so limiting use.
                        //I don't need answers, I need results
                        if (ir.FullName.EndsWith(".heic"))
                        {
                            if (System.IO.File.Exists(ir.FullName))
                            {
                                using (MagickImage original = new MagickImage(ir.FullName))
                                {
                                    original.Format = MagickFormat.Jpg;
                                    original.Write(ir.FullName.Replace(".heic", ".jpg"));
                                    System.IO.File.Delete(ir.FullName);
                                }
                            }
                            ir.FullName = ir.FullName.Replace(".heic", ".jpg");
                        }

                        using (var fileStream = System.IO.File.Open(ir.FullName, FileMode.Open))
                        {
                            using (var bmp = LoadBitmap(fileStream, out SKEncodedOrigin origin))
                            {
                                SKBitmap bitmap = bmp;

                                var bitmapRatio = (float)bitmap.Width / bitmap.Height;
                                var resizeRatio = (float)targetWidth / targetHeight;

                                if (bitmapRatio > resizeRatio)
                                { // original is more "landscape"
                                    targetHeight = (int)Math.Round(bitmap.Height * ((float)targetWidth / bitmap.Width));
                                }
                                else
                                {
                                    targetWidth = (int)Math.Round(bitmap.Width * ((float)targetHeight / bitmap.Height));
                                }

                                var resizedImageInfo = new SKImageInfo(targetWidth, targetHeight, SKImageInfo.PlatformColorType, bitmap.AlphaType);

                                using (var resizedBmp = bitmap.Resize(resizedImageInfo, SKFilterQuality.High))
                                {

                                    SKBitmap resizedBitmap = resizedBmp;
                                    using (var resizedImage = SKImage.FromBitmap(resizedBitmap))
                                    {
                                        var encodeFormat = SKEncodedImageFormat.Jpeg;

                                        var data = resizedImage.Encode(encodeFormat, 90);

                                        using (var resizedFile = System.IO.File.Create(targetPath))
                                        {
                                            data.SaveTo(resizedFile);
                                        }
                                    };

                                }

                                bitmap.Dispose();
                            }
                        }

                    }
                    catch {/*Don't care right now*/ }
                }
                
   
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (chkClearBatchPost.Checked) {
                lbBatchFiles.Items.Clear();
            }

            MessageBox.Show("Batch complete", "Notice", MessageBoxButtons.OK);
        }

        private void bwResizeWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {

            pbResizeProgress.Value = e.ProgressPercentage;
                                 
        }

        private SKBitmap LoadBitmap(System.IO.Stream stream, out SKEncodedOrigin origin)
        {
            using (var s = new SKManagedStream(stream))
            {
                using (var codec = SKCodec.Create(s))
                {
                    origin = codec.EncodedOrigin;
                    var info = codec.Info;
                    var bitmap = new SKBitmap(info.Width, info.Height, SKImageInfo.PlatformColorType, info.IsOpaque ? SKAlphaType.Opaque : SKAlphaType.Premul);

                    IntPtr length;
                    var result = codec.GetPixels(bitmap.Info, bitmap.GetPixels(out length));
                    if (result == SKCodecResult.Success || result == SKCodecResult.IncompleteInput)
                    {
                        return bitmap;
                    }
                    else
                    {
                        throw new ArgumentException("Unable to load bitmap from provided data");
                    }
                }
            }
        }
    }
}
