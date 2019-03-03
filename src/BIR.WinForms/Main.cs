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

        

        public Main()
        {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            var result = sourceFolderPicker.ShowDialog();
            if (result != DialogResult.Cancel)
            {

                lbSourceFiles.Items.Clear();
                lbSourceFiles.DisplayMember = "Name";
                DirectoryInfo srcFolder = new DirectoryInfo(sourceFolderPicker.SelectedPath);

                foreach(FileInfo fi in srcFolder.GetFiles())
                {

                    lbSourceFiles.Items.Add(new BIR.Common.Models.ImageReference { Name = fi.Name, FullName = fi.FullName });
                }
                               
            }
        }

        private void btnAddToBatch_Click(object sender, EventArgs e)
        {
            
            foreach(BIR.Common.Models.ImageReference ir in lbSourceFiles.SelectedItems)
            {

                    lbBatchFiles.Items.Add(ir);

            }


        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            var result = sourceFolderPicker.ShowDialog();
            if (result != DialogResult.Cancel)
            {

                foreach (BIR.Common.Models.ImageReference ir in lbBatchFiles.Items)
                {

                    Image srcImage = Image.FromFile(ir.FullName);

                    var resized = BIR.Common.ImageUtility.ResizeImage(srcImage, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), Common.Enums.ResizeMode.Contain);


                    resized.Save(Path.Combine(sourceFolderPicker.SelectedPath, ir.Name),System.Drawing.Imaging.ImageFormat.Jpeg);
                    



                }


            }




        }


    }
}
