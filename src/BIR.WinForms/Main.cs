using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIR.WinForms
{
    public partial class Main : Form
    {

        string srcPath;
        string destPath;

        public Main()
        {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(srcPath)) { folderPicker.SelectedPath = srcPath; }

            var result = folderPicker.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                srcPath = folderPicker.SelectedPath;
                lbSourceFiles.Items.Clear();
                lbSourceFiles.DisplayMember = "Name";
                DirectoryInfo srcFolder = new DirectoryInfo(srcPath);

                foreach (FileInfo fi in srcFolder.GetFiles().Where(fi=> (new string[]{ ".jpg",".png",".bmp",".tif",".jpeg"}).Contains(fi.Extension.ToLower())))
                {
                    lbSourceFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, FullName = fi.FullName });
                }

            }
        }

        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            foreach (BIR.Common.Models.ImageReference ir in lbSourceFiles.SelectedItems)
            {
                lbBatchFiles.Items.Add(ir);
            }
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(destPath))
            {
                folderPicker.SelectedPath = destPath;
            }
            else if (!string.IsNullOrWhiteSpace(srcPath))
            {
                folderPicker.SelectedPath = srcPath;
            }

            var result = folderPicker.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                destPath = folderPicker.SelectedPath;
            }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            int targetWidth;
            int targetHeight;
            bool resizeModeSet = false;
            Common.Enums.ResizeMode resizeMode = Common.Enums.ResizeMode.Contain;

            if (!Int32.TryParse(txtHeight.Text, out targetHeight) || !(Int32.TryParse(txtWidth.Text, out targetWidth)))
            {
                MessageBox.Show("Height and Width must be set", "Error", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(destPath))
            {
                MessageBox.Show("Select a destination path", "Error", MessageBoxButtons.OK);
                return;
            }


            foreach (RadioButton rbtn in gbResizeMode.Controls)
            {
                if (rbtn.Checked)
                {
                    resizeMode = (Common.Enums.ResizeMode)Convert.ToInt32((rbtn.Tag));
                    resizeModeSet = true;
                }
            }
            if (!resizeModeSet)
            {
                MessageBox.Show("Resize Mode must be selected", "Error", MessageBoxButtons.OK);
                return;
            }


            foreach (BIR.Common.Models.ImageReference ir in lbBatchFiles.Items)
            {
                Image srcImage = Image.FromFile(ir.FullName);
                var resized = BIR.Common.ImageUtility.ResizeImage(srcImage, targetWidth, targetHeight, resizeMode);
                resized.Save(Path.Combine(destPath, ir.Name), System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            MessageBox.Show("Batch omplete", "Notice", MessageBoxButtons.OK);
        }
    }
}
