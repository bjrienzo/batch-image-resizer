namespace BIR.WinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcess = new System.Windows.Forms.Button();
            this.folderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.lbSourceFiles = new System.Windows.Forms.ListBox();
            this.lbBatchFiles = new System.Windows.Forms.ListBox();
            this.btnAddToBatch = new System.Windows.Forms.Button();
            this.btnSelectOutputFolder = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.rbtnResizeModeStretch = new System.Windows.Forms.RadioButton();
            this.gbResizeMode = new System.Windows.Forms.GroupBox();
            this.rbtnResizeModeCover = new System.Windows.Forms.RadioButton();
            this.rbtnResizeModeContain = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBatchFiles = new System.Windows.Forms.Label();
            this.gbResizeMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(344, 236);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(173, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(12, 12);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(140, 23);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "Browse";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // lbSourceFiles
            // 
            this.lbSourceFiles.DisplayMember = "Name";
            this.lbSourceFiles.FormattingEnabled = true;
            this.lbSourceFiles.Location = new System.Drawing.Point(12, 47);
            this.lbSourceFiles.Name = "lbSourceFiles";
            this.lbSourceFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSourceFiles.Size = new System.Drawing.Size(140, 186);
            this.lbSourceFiles.TabIndex = 1;
            // 
            // lbBatchFiles
            // 
            this.lbBatchFiles.DisplayMember = "Name";
            this.lbBatchFiles.FormattingEnabled = true;
            this.lbBatchFiles.Location = new System.Drawing.Point(170, 47);
            this.lbBatchFiles.Name = "lbBatchFiles";
            this.lbBatchFiles.Size = new System.Drawing.Size(160, 212);
            this.lbBatchFiles.TabIndex = 3;
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(12, 236);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(140, 23);
            this.btnAddToBatch.TabIndex = 4;
            this.btnAddToBatch.Text = "Add To Batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(344, 12);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(173, 23);
            this.btnSelectOutputFolder.TabIndex = 5;
            this.btnSelectOutputFolder.Text = "Select Destination";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(58, 54);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 57);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(58, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 8;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 22);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 9;
            this.lblWidth.Text = "Width:";
            // 
            // rbtnResizeModeStretch
            // 
            this.rbtnResizeModeStretch.AutoSize = true;
            this.rbtnResizeModeStretch.Location = new System.Drawing.Point(6, 65);
            this.rbtnResizeModeStretch.Name = "rbtnResizeModeStretch";
            this.rbtnResizeModeStretch.Size = new System.Drawing.Size(59, 17);
            this.rbtnResizeModeStretch.TabIndex = 10;
            this.rbtnResizeModeStretch.TabStop = true;
            this.rbtnResizeModeStretch.Tag = "3";
            this.rbtnResizeModeStretch.Text = "Stretch";
            this.rbtnResizeModeStretch.UseVisualStyleBackColor = true;
            // 
            // gbResizeMode
            // 
            this.gbResizeMode.Controls.Add(this.rbtnResizeModeCover);
            this.gbResizeMode.Controls.Add(this.rbtnResizeModeContain);
            this.gbResizeMode.Controls.Add(this.rbtnResizeModeStretch);
            this.gbResizeMode.Location = new System.Drawing.Point(344, 140);
            this.gbResizeMode.Name = "gbResizeMode";
            this.gbResizeMode.Size = new System.Drawing.Size(173, 90);
            this.gbResizeMode.TabIndex = 11;
            this.gbResizeMode.TabStop = false;
            this.gbResizeMode.Text = "Resize Mode";
            // 
            // rbtnResizeModeCover
            // 
            this.rbtnResizeModeCover.AutoSize = true;
            this.rbtnResizeModeCover.Location = new System.Drawing.Point(6, 42);
            this.rbtnResizeModeCover.Name = "rbtnResizeModeCover";
            this.rbtnResizeModeCover.Size = new System.Drawing.Size(53, 17);
            this.rbtnResizeModeCover.TabIndex = 12;
            this.rbtnResizeModeCover.TabStop = true;
            this.rbtnResizeModeCover.Tag = "1";
            this.rbtnResizeModeCover.Text = "Cover";
            this.rbtnResizeModeCover.UseVisualStyleBackColor = true;
            // 
            // rbtnResizeModeContain
            // 
            this.rbtnResizeModeContain.AutoSize = true;
            this.rbtnResizeModeContain.Location = new System.Drawing.Point(6, 19);
            this.rbtnResizeModeContain.Name = "rbtnResizeModeContain";
            this.rbtnResizeModeContain.Size = new System.Drawing.Size(61, 17);
            this.rbtnResizeModeContain.TabIndex = 11;
            this.rbtnResizeModeContain.TabStop = true;
            this.rbtnResizeModeContain.Tag = "2";
            this.rbtnResizeModeContain.Text = "Contain";
            this.rbtnResizeModeContain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Location = new System.Drawing.Point(344, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // lblBatchFiles
            // 
            this.lblBatchFiles.AutoSize = true;
            this.lblBatchFiles.Location = new System.Drawing.Point(170, 21);
            this.lblBatchFiles.Name = "lblBatchFiles";
            this.lblBatchFiles.Size = new System.Drawing.Size(59, 13);
            this.lblBatchFiles.TabIndex = 13;
            this.lblBatchFiles.Text = "Batch Files";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 265);
            this.Controls.Add(this.lblBatchFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbResizeMode);
            this.Controls.Add(this.btnSelectOutputFolder);
            this.Controls.Add(this.btnAddToBatch);
            this.Controls.Add(this.lbBatchFiles);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.lbSourceFiles);
            this.Controls.Add(this.btnProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.gbResizeMode.ResumeLayout(false);
            this.gbResizeMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.FolderBrowserDialog folderPicker;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.ListBox lbSourceFiles;
        private System.Windows.Forms.ListBox lbBatchFiles;
        private System.Windows.Forms.Button btnAddToBatch;
        private System.Windows.Forms.Button btnSelectOutputFolder;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.RadioButton rbtnResizeModeStretch;
        private System.Windows.Forms.GroupBox gbResizeMode;
        private System.Windows.Forms.RadioButton rbtnResizeModeContain;
        private System.Windows.Forms.RadioButton rbtnResizeModeCover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBatchFiles;
    }
}