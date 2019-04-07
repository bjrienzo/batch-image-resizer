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
                DirectoryInfo srcFolder = new DirectoryInfo(srcPath);

                foreach (FileInfo fi in srcFolder.GetFiles().Where(fi => acceptedExtensions.Contains(fi.Extension.ToLower()))) {
                    lbSourceFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, FullName = fi.FullName });
                }

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

                    var targetPath = Path.Combine(destPath, ir.Name);
                    if (File.Exists(targetPath)) {
                        switch (collisionAction) {
                            case Common.Enums.CollisionAction.Skip:
                                continue;
                            case Common.Enums.CollisionAction.Overwrite:
                                File.Delete(targetPath);
                                break;
                        }
                    }

                    Image srcImage = Image.FromFile(ir.FullName);
                    var resized = BIR.Common.ImageUtility.ResizeImage(srcImage, targetWidth, targetHeight, resizeMode);
                    resized.Save(targetPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    resized.Dispose();
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
    }
}
