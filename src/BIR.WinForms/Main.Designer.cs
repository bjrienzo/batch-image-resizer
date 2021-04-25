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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBatchFiles = new System.Windows.Forms.Label();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.gbCollisionAction = new System.Windows.Forms.GroupBox();
            this.rbtnOverwrite = new System.Windows.Forms.RadioButton();
            this.rbtnRename = new System.Windows.Forms.RadioButton();
            this.rbtnSkip = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkClearBatchPost = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMaintainRelativePath = new System.Windows.Forms.CheckBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.gbBatch = new System.Windows.Forms.GroupBox();
            this.btnClearBatch = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.bwResizeWorker = new System.ComponentModel.BackgroundWorker();
            this.pbResizeProgress = new System.Windows.Forms.ProgressBar();
            this.lbDimensions = new System.Windows.Forms.ListBox();
            this.btnAddDimension = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.gbCollisionAction.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbBatch.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(10, 370);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(288, 27);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(7, 22);
            this.btnSelectSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(219, 27);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "Browse";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // lbSourceFiles
            // 
            this.lbSourceFiles.DisplayMember = "Name";
            this.lbSourceFiles.FormattingEnabled = true;
            this.lbSourceFiles.ItemHeight = 15;
            this.lbSourceFiles.Location = new System.Drawing.Point(7, 55);
            this.lbSourceFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbSourceFiles.Name = "lbSourceFiles";
            this.lbSourceFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSourceFiles.Size = new System.Drawing.Size(219, 304);
            this.lbSourceFiles.TabIndex = 1;
            // 
            // lbBatchFiles
            // 
            this.lbBatchFiles.AllowDrop = true;
            this.lbBatchFiles.DisplayMember = "Name";
            this.lbBatchFiles.FormattingEnabled = true;
            this.lbBatchFiles.ItemHeight = 15;
            this.lbBatchFiles.Location = new System.Drawing.Point(8, 22);
            this.lbBatchFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbBatchFiles.Name = "lbBatchFiles";
            this.lbBatchFiles.Size = new System.Drawing.Size(218, 334);
            this.lbBatchFiles.TabIndex = 3;
            this.lbBatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbBatchFiles_DragDrop);
            this.lbBatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbBatchFiles_DragEnter);
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(7, 370);
            this.btnAddToBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(219, 27);
            this.btnAddToBatch.TabIndex = 4;
            this.btnAddToBatch.Text = "Add Selected To Batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(9, 22);
            this.btnSelectOutputFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(88, 27);
            this.btnSelectOutputFolder.TabIndex = 5;
            this.btnSelectOutputFolder.Text = "Select Destination";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(85, 21);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(50, 23);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "1024";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(7, 21);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(49, 23);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "1024";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDimension);
            this.groupBox1.Controls.Add(this.lbDimensions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Location = new System.Drawing.Point(10, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(288, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            // 
            // lblBatchFiles
            // 
            this.lblBatchFiles.AutoSize = true;
            this.lblBatchFiles.Location = new System.Drawing.Point(203, 32);
            this.lblBatchFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchFiles.Name = "lblBatchFiles";
            this.lblBatchFiles.Size = new System.Drawing.Size(0, 15);
            this.lblBatchFiles.TabIndex = 13;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.gbCollisionAction);
            this.gbOutput.Controls.Add(this.gbOptions);
            this.gbOutput.Controls.Add(this.groupBox2);
            this.gbOutput.Controls.Add(this.groupBox1);
            this.gbOutput.Controls.Add(this.btnProcess);
            this.gbOutput.Location = new System.Drawing.Point(483, 8);
            this.gbOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOutput.Size = new System.Drawing.Size(306, 406);
            this.gbOutput.TabIndex = 14;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // gbCollisionAction
            // 
            this.gbCollisionAction.Controls.Add(this.rbtnOverwrite);
            this.gbCollisionAction.Controls.Add(this.rbtnRename);
            this.gbCollisionAction.Controls.Add(this.rbtnSkip);
            this.gbCollisionAction.Location = new System.Drawing.Point(10, 297);
            this.gbCollisionAction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCollisionAction.Name = "gbCollisionAction";
            this.gbCollisionAction.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCollisionAction.Size = new System.Drawing.Size(286, 67);
            this.gbCollisionAction.TabIndex = 15;
            this.gbCollisionAction.TabStop = false;
            this.gbCollisionAction.Text = "Collisions";
            // 
            // rbtnOverwrite
            // 
            this.rbtnOverwrite.AutoSize = true;
            this.rbtnOverwrite.Location = new System.Drawing.Point(200, 22);
            this.rbtnOverwrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnOverwrite.Name = "rbtnOverwrite";
            this.rbtnOverwrite.Size = new System.Drawing.Size(76, 19);
            this.rbtnOverwrite.TabIndex = 2;
            this.rbtnOverwrite.Tag = "4";
            this.rbtnOverwrite.Text = "Overwrite";
            this.rbtnOverwrite.UseVisualStyleBackColor = true;
            // 
            // rbtnRename
            // 
            this.rbtnRename.AutoSize = true;
            this.rbtnRename.Location = new System.Drawing.Point(90, 22);
            this.rbtnRename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnRename.Name = "rbtnRename";
            this.rbtnRename.Size = new System.Drawing.Size(95, 19);
            this.rbtnRename.TabIndex = 1;
            this.rbtnRename.Tag = "2";
            this.rbtnRename.Text = "Rename New";
            this.rbtnRename.UseVisualStyleBackColor = true;
            // 
            // rbtnSkip
            // 
            this.rbtnSkip.AutoSize = true;
            this.rbtnSkip.Checked = true;
            this.rbtnSkip.Location = new System.Drawing.Point(9, 22);
            this.rbtnSkip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnSkip.Name = "rbtnSkip";
            this.rbtnSkip.Size = new System.Drawing.Size(47, 19);
            this.rbtnSkip.TabIndex = 0;
            this.rbtnSkip.TabStop = true;
            this.rbtnSkip.Tag = "1";
            this.rbtnSkip.Text = "Skip";
            this.rbtnSkip.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkClearBatchPost);
            this.gbOptions.Location = new System.Drawing.Point(10, 234);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOptions.Size = new System.Drawing.Size(288, 54);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkClearBatchPost
            // 
            this.chkClearBatchPost.AutoSize = true;
            this.chkClearBatchPost.Location = new System.Drawing.Point(7, 22);
            this.chkClearBatchPost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkClearBatchPost.Name = "chkClearBatchPost";
            this.chkClearBatchPost.Size = new System.Drawing.Size(148, 19);
            this.chkClearBatchPost.TabIndex = 0;
            this.chkClearBatchPost.Text = "Clear batch when done";
            this.chkClearBatchPost.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMaintainRelativePath);
            this.groupBox2.Controls.Add(this.lblOutputPath);
            this.groupBox2.Controls.Add(this.btnSelectOutputFolder);
            this.groupBox2.Location = new System.Drawing.Point(10, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(288, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Path";
            // 
            // chkMaintainRelativePath
            // 
            this.chkMaintainRelativePath.AutoSize = true;
            this.chkMaintainRelativePath.Location = new System.Drawing.Point(9, 55);
            this.chkMaintainRelativePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMaintainRelativePath.Name = "chkMaintainRelativePath";
            this.chkMaintainRelativePath.Size = new System.Drawing.Size(144, 19);
            this.chkMaintainRelativePath.TabIndex = 7;
            this.chkMaintainRelativePath.Text = "Maintain Relative Path";
            this.chkMaintainRelativePath.UseVisualStyleBackColor = true;
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Location = new System.Drawing.Point(104, 28);
            this.lblOutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(177, 21);
            this.lblOutputPath.TabIndex = 6;
            this.lblOutputPath.Text = "None Selected";
            // 
            // gbBatch
            // 
            this.gbBatch.Controls.Add(this.btnClearBatch);
            this.gbBatch.Controls.Add(this.lbBatchFiles);
            this.gbBatch.Location = new System.Drawing.Point(243, 8);
            this.gbBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbBatch.Name = "gbBatch";
            this.gbBatch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbBatch.Size = new System.Drawing.Size(233, 406);
            this.gbBatch.TabIndex = 15;
            this.gbBatch.TabStop = false;
            this.gbBatch.Text = "Batch";
            // 
            // btnClearBatch
            // 
            this.btnClearBatch.Location = new System.Drawing.Point(8, 370);
            this.btnClearBatch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearBatch.Name = "btnClearBatch";
            this.btnClearBatch.Size = new System.Drawing.Size(218, 27);
            this.btnClearBatch.TabIndex = 4;
            this.btnClearBatch.Text = "Clear Batch";
            this.btnClearBatch.UseVisualStyleBackColor = true;
            this.btnClearBatch.Click += new System.EventHandler(this.btnClearBatch_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnSelectSource);
            this.gbInput.Controls.Add(this.lbSourceFiles);
            this.gbInput.Controls.Add(this.btnAddToBatch);
            this.gbInput.Controls.Add(this.lblBatchFiles);
            this.gbInput.Location = new System.Drawing.Point(2, 8);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInput.Size = new System.Drawing.Size(233, 406);
            this.gbInput.TabIndex = 16;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // bwResizeWorker
            // 
            this.bwResizeWorker.WorkerReportsProgress = true;
            this.bwResizeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwResizeWorker_DoWork);
            this.bwResizeWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwResizeWorker_ProgressChanged);
            this.bwResizeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pbResizeProgress
            // 
            this.pbResizeProgress.Location = new System.Drawing.Point(2, 421);
            this.pbResizeProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbResizeProgress.Name = "pbResizeProgress";
            this.pbResizeProgress.Size = new System.Drawing.Size(786, 27);
            this.pbResizeProgress.TabIndex = 17;
            // 
            // lbDimensions
            // 
            this.lbDimensions.FormattingEnabled = true;
            this.lbDimensions.ItemHeight = 15;
            this.lbDimensions.Location = new System.Drawing.Point(7, 50);
            this.lbDimensions.Name = "lbDimensions";
            this.lbDimensions.Size = new System.Drawing.Size(274, 64);
            this.lbDimensions.TabIndex = 10;
            // 
            // btnAddDimension
            // 
            this.btnAddDimension.Location = new System.Drawing.Point(142, 21);
            this.btnAddDimension.Name = "btnAddDimension";
            this.btnAddDimension.Size = new System.Drawing.Size(75, 23);
            this.btnAddDimension.TabIndex = 11;
            this.btnAddDimension.Text = "Add";
            this.btnAddDimension.UseVisualStyleBackColor = true;
            this.btnAddDimension.Click += new System.EventHandler(this.btnAddDimension_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 455);
            this.Controls.Add(this.pbResizeProgress);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbBatch);
            this.Controls.Add(this.gbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Image Resizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbCollisionAction.ResumeLayout(false);
            this.gbCollisionAction.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbBatch.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBatchFiles;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.GroupBox gbBatch;
        private System.Windows.Forms.CheckBox chkClearBatchPost;
        private System.Windows.Forms.Button btnClearBatch;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.ComponentModel.BackgroundWorker bwResizeWorker;
        private System.Windows.Forms.GroupBox gbCollisionAction;
        private System.Windows.Forms.RadioButton rbtnOverwrite;
        private System.Windows.Forms.RadioButton rbtnRename;
        private System.Windows.Forms.RadioButton rbtnSkip;
        private System.Windows.Forms.ProgressBar pbResizeProgress;
        private System.Windows.Forms.CheckBox chkMaintainRelativePath;
        private System.Windows.Forms.Button btnAddDimension;
        private System.Windows.Forms.ListBox lbDimensions;
    }
}