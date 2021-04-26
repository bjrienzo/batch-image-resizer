using BIR.Common.Models;
using ImageMagick;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIR.WinForms {
    public partial class Main : Form {

        readonly string[] acceptedExtensions = new string[] { ".jpg", ".png", ".bmp", ".tif", ".jpeg", ".heic" };
        string srcPath; //This needs to be rethought, there is no requirement for the srcpath to stay the same
        string destPath;
        object baseResize; //This feels gross, but if it works then fine for now

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
            DirectoryInfo srcFolder = new(rootPath);

            foreach (FileInfo fi in srcFolder.GetFiles().Where(fi => acceptedExtensions.Contains(fi.Extension.ToLower())))
            {
                lbSourceFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, DirectoryPath = fi.DirectoryName, RootPath = srcPath });
            }

            foreach(DirectoryInfo di in srcFolder.GetDirectories())
            {
                BuildFileTreeRecursive(di.FullName);
            }
        }

        private void btnAddToBatch_Click(object sender, EventArgs e) {
            foreach (ImageReference ir in lbSourceFiles.SelectedItems) {
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
            bool collisionActionSet = false;

            if (string.IsNullOrWhiteSpace(destPath)) {
                MessageBox.Show("Select a destination path", "Error", MessageBoxButtons.OK);
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

            baseResize = lbDimensions.SelectedItem;

            if (bwResizeWorker.IsBusy != true) {
                bwResizeWorker.RunWorkerAsync();
            }

        }

        private void lbBatchFiles_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) {
                var fi = new FileInfo(file);
                if (acceptedExtensions.Contains(fi.Extension.ToLower())) {
                    lbBatchFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, DirectoryPath = fi.FullName });
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
            
            var result = Parallel.ForEach(lbBatchFiles.Items.Cast<ImageReference>(), ir =>
            {
                worker.ReportProgress(Convert.ToInt16((++i / lbBatchFiles.Items.Count) * 100));

                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {

                        foreach (ResizeParameter resize in lbDimensions.Items)
                        {

                            //Determine name for target file
                            var rootName = Path.GetFileNameWithoutExtension(ir.Name);
                            var targetWidth = resize.TargetWidth;
                            var targetHeight = resize.TargetHeight;

                            string resizeName;
                            if (baseResize != null && baseResize == resize)
                            {
                                resizeName = $"{rootName}.jpg";
                            }
                            else
                            {
                                resizeName = $"{rootName}_{targetWidth}x{targetHeight}.jpg";
                            }
                            
                            var sourcePath = Path.Combine(ir.DirectoryPath, ir.Name);

                            //Determine full path for the target file
                            string targetPath = chkMaintainRelativePath.Checked switch
                            {
                                true => Path.Combine(destPath, ir.DirectoryPath.Replace(ir.RootPath + "\\", ""), resizeName),
                                false => Path.Combine(destPath, resizeName)
                            };

                            //Check for the existence of a file already in that path and apply the chosen action
                            if (File.Exists(targetPath))
                            {
                                switch (collisionAction)
                                {
                                    case Common.Enums.CollisionAction.Skip:
                                        return;
                                    case Common.Enums.CollisionAction.Overwrite:
                                        File.Delete(targetPath);
                                        break;
                                    case Common.Enums.CollisionAction.RenameResize:
                                        resizeName = DateTime.Now.ToString("yyyyMMddHHmmssff") + "_" + ir.Name;
                                        targetPath = Path.Combine(destPath, resizeName);
                                        break;
                                    case Common.Enums.CollisionAction.RenameExisting:
                                        var rename = DateTime.Now.ToString("yyyyMMddHHmmssff") + "_" + ir.Name;
                                        var copyPath = Path.Combine(destPath, rename);
                                        File.Move(targetPath, copyPath);
                                        break;
                                }
                            }

                            //If the target directory doesn't exist, create it
                            var targetDir = new FileInfo(targetPath).Directory;
                            if (!targetDir.Exists) { System.IO.Directory.CreateDirectory(targetDir.FullName); }

                            //If the source is an heic, convert it to jpg please. Thank you Apple.
                            if (sourcePath.EndsWith(".heic"))
                            {
                                if (System.IO.File.Exists(sourcePath))
                                {
                                    using MagickImage original = new(sourcePath)
                                    {
                                        Format = MagickFormat.Jpg,
                                    };
                                    original.Write(sourcePath.Replace(".heic", ".jpg"));
                                    System.IO.File.Delete(sourcePath); //Yeah, its fine, they're my pictures
                                }
                                sourcePath = sourcePath.Replace(".heic", ".jpg");
                            }

                            //Open the the source file for processing
                            using var fileStream = System.IO.File.Open(sourcePath, FileMode.Open);
                            using SKBitmap bitmap = LoadBitmap(fileStream, out SKEncodedOrigin origin);

                            //Determine how the image will best fit within the target dimensions
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

                            //Finally, let's do the resize
                            var resizedImageInfo = new SKImageInfo(targetWidth, targetHeight, SKImageInfo.PlatformColorType, bitmap.AlphaType);
                            using SKBitmap resizedBitmap = bitmap.Resize(resizedImageInfo, SKFilterQuality.High);
                            using var resizedImage = SKImage.FromBitmap(resizedBitmap);
                            var encodeFormat = SKEncodedImageFormat.Jpeg;
                            var data = resizedImage.Encode(encodeFormat, 90);
                            using var resizedFile = System.IO.File.Create(targetPath);
                            data.SaveTo(resizedFile);

                        }
                        
                    }
                    catch (Exception ex) {
                        
                        /*Don't care right now*/ 
                    
                    
                    }
                }
            });

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

        private static SKBitmap LoadBitmap(System.IO.Stream stream, out SKEncodedOrigin origin)
        {
            using var s = new SKManagedStream(stream);
            using var codec = SKCodec.Create(s);
            origin = codec.EncodedOrigin;
            var info = codec.Info;
            var bitmap = new SKBitmap(info.Width, info.Height, SKImageInfo.PlatformColorType, info.IsOpaque ? SKAlphaType.Opaque : SKAlphaType.Premul);

            var result = codec.GetPixels(bitmap.Info, bitmap.GetPixels(out IntPtr length));
            if (result == SKCodecResult.Success || result == SKCodecResult.IncompleteInput)
            {
                return bitmap;
            }
            else
            {
                throw new ArgumentException("Unable to load bitmap from provided data");
            }
        }

        private void btnAddDimension_Click(object sender, EventArgs e)
        {
            lbDimensions.DisplayMember = "DisplayText"; //We'll do it live
            if (int.TryParse(txtWidth.Text, out int width))
            {
                if (int.TryParse(txtHeight.Text, out int height))
                {
                    lbDimensions.Items.Add(new ResizeParameter(width, height));
                    txtWidth.Text = "";
                    txtHeight.Text = "";
                }
                else
                {
                    lbDimensions.Items.Add(new ResizeParameter(width, width));
                    txtWidth.Text = "";
                    txtHeight.Text = "";
                }
            }
            
        }
    }
}
