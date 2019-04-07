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
            this.rbtnResizeModeStretch = new System.Windows.Forms.RadioButton();
            this.gbResizeMode = new System.Windows.Forms.GroupBox();
            this.rbtnResizeModeCover = new System.Windows.Forms.RadioButton();
            this.rbtnResizeModeContain = new System.Windows.Forms.RadioButton();
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
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.gbBatch = new System.Windows.Forms.GroupBox();
            this.btnClearBatch = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.bwResizeWorker = new System.ComponentModel.BackgroundWorker();
            this.pbResizeProgress = new System.Windows.Forms.ProgressBar();
            this.gbResizeMode.SuspendLayout();
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
            this.btnProcess.Location = new System.Drawing.Point(9, 302);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(247, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(6, 19);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(188, 23);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "Browse";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // lbSourceFiles
            // 
            this.lbSourceFiles.DisplayMember = "Name";
            this.lbSourceFiles.FormattingEnabled = true;
            this.lbSourceFiles.Location = new System.Drawing.Point(6, 48);
            this.lbSourceFiles.Name = "lbSourceFiles";
            this.lbSourceFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSourceFiles.Size = new System.Drawing.Size(188, 251);
            this.lbSourceFiles.TabIndex = 1;
            // 
            // lbBatchFiles
            // 
            this.lbBatchFiles.AllowDrop = true;
            this.lbBatchFiles.DisplayMember = "Name";
            this.lbBatchFiles.FormattingEnabled = true;
            this.lbBatchFiles.Location = new System.Drawing.Point(7, 19);
            this.lbBatchFiles.Name = "lbBatchFiles";
            this.lbBatchFiles.Size = new System.Drawing.Size(187, 277);
            this.lbBatchFiles.TabIndex = 3;
            this.lbBatchFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbBatchFiles_DragDrop);
            this.lbBatchFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbBatchFiles_DragEnter);
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Location = new System.Drawing.Point(6, 302);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(188, 23);
            this.btnAddToBatch.TabIndex = 4;
            this.btnAddToBatch.Text = "Add Selected To Batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // btnSelectOutputFolder
            // 
            this.btnSelectOutputFolder.Location = new System.Drawing.Point(8, 19);
            this.btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            this.btnSelectOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputFolder.TabIndex = 5;
            this.btnSelectOutputFolder.Text = "Select Destination";
            this.btnSelectOutputFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutputFolder.Click += new System.EventHandler(this.btnSelectOutputFolder_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(148, 19);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(77, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(22, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(77, 20);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "Width";
            // 
            // rbtnResizeModeStretch
            // 
            this.rbtnResizeModeStretch.AutoSize = true;
            this.rbtnResizeModeStretch.Location = new System.Drawing.Point(182, 19);
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
            this.gbResizeMode.Location = new System.Drawing.Point(9, 129);
            this.gbResizeMode.Name = "gbResizeMode";
            this.gbResizeMode.Size = new System.Drawing.Size(247, 48);
            this.gbResizeMode.TabIndex = 11;
            this.gbResizeMode.TabStop = false;
            this.gbResizeMode.Text = "Resize Mode";
            // 
            // rbtnResizeModeCover
            // 
            this.rbtnResizeModeCover.AutoSize = true;
            this.rbtnResizeModeCover.Location = new System.Drawing.Point(102, 19);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Location = new System.Drawing.Point(9, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 51);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            // 
            // lblBatchFiles
            // 
            this.lblBatchFiles.AutoSize = true;
            this.lblBatchFiles.Location = new System.Drawing.Point(174, 28);
            this.lblBatchFiles.Name = "lblBatchFiles";
            this.lblBatchFiles.Size = new System.Drawing.Size(0, 13);
            this.lblBatchFiles.TabIndex = 13;
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.gbCollisionAction);
            this.gbOutput.Controls.Add(this.gbOptions);
            this.gbOutput.Controls.Add(this.groupBox2);
            this.gbOutput.Controls.Add(this.gbResizeMode);
            this.gbOutput.Controls.Add(this.groupBox1);
            this.gbOutput.Controls.Add(this.btnProcess);
            this.gbOutput.Location = new System.Drawing.Point(414, 7);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(262, 331);
            this.gbOutput.TabIndex = 14;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // gbCollisionAction
            // 
            this.gbCollisionAction.Controls.Add(this.rbtnOverwrite);
            this.gbCollisionAction.Controls.Add(this.rbtnRename);
            this.gbCollisionAction.Controls.Add(this.rbtnSkip);
            this.gbCollisionAction.Location = new System.Drawing.Point(9, 238);
            this.gbCollisionAction.Name = "gbCollisionAction";
            this.gbCollisionAction.Size = new System.Drawing.Size(245, 58);
            this.gbCollisionAction.TabIndex = 15;
            this.gbCollisionAction.TabStop = false;
            this.gbCollisionAction.Text = "Collisions";
            // 
            // rbtnOverwrite
            // 
            this.rbtnOverwrite.AutoSize = true;
            this.rbtnOverwrite.Location = new System.Drawing.Point(171, 19);
            this.rbtnOverwrite.Name = "rbtnOverwrite";
            this.rbtnOverwrite.Size = new System.Drawing.Size(70, 17);
            this.rbtnOverwrite.TabIndex = 2;
            this.rbtnOverwrite.TabStop = true;
            this.rbtnOverwrite.Tag = "4";
            this.rbtnOverwrite.Text = "Overwrite";
            this.rbtnOverwrite.UseVisualStyleBackColor = true;
            // 
            // rbtnRename
            // 
            this.rbtnRename.AutoSize = true;
            this.rbtnRename.Location = new System.Drawing.Point(77, 19);
            this.rbtnRename.Name = "rbtnRename";
            this.rbtnRename.Size = new System.Drawing.Size(90, 17);
            this.rbtnRename.TabIndex = 1;
            this.rbtnRename.TabStop = true;
            this.rbtnRename.Tag = "2";
            this.rbtnRename.Text = "Rename New";
            this.rbtnRename.UseVisualStyleBackColor = true;
            // 
            // rbtnSkip
            // 
            this.rbtnSkip.AutoSize = true;
            this.rbtnSkip.Location = new System.Drawing.Point(8, 19);
            this.rbtnSkip.Name = "rbtnSkip";
            this.rbtnSkip.Size = new System.Drawing.Size(46, 17);
            this.rbtnSkip.TabIndex = 0;
            this.rbtnSkip.TabStop = true;
            this.rbtnSkip.Tag = "1";
            this.rbtnSkip.Text = "Skip";
            this.rbtnSkip.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkClearBatchPost);
            this.gbOptions.Location = new System.Drawing.Point(9, 184);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(247, 47);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkClearBatchPost
            // 
            this.chkClearBatchPost.AutoSize = true;
            this.chkClearBatchPost.Location = new System.Drawing.Point(6, 19);
            this.chkClearBatchPost.Name = "chkClearBatchPost";
            this.chkClearBatchPost.Size = new System.Drawing.Size(136, 17);
            this.chkClearBatchPost.TabIndex = 0;
            this.chkClearBatchPost.Text = "Clear batch when done";
            this.chkClearBatchPost.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutputPath);
            this.groupBox2.Controls.Add(this.btnSelectOutputFolder);
            this.groupBox2.Location = new System.Drawing.Point(9, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 52);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Path";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.Location = new System.Drawing.Point(89, 24);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(152, 18);
            this.lblOutputPath.TabIndex = 6;
            this.lblOutputPath.Text = "None Selected";
            // 
            // gbBatch
            // 
            this.gbBatch.Controls.Add(this.btnClearBatch);
            this.gbBatch.Controls.Add(this.lbBatchFiles);
            this.gbBatch.Location = new System.Drawing.Point(208, 7);
            this.gbBatch.Name = "gbBatch";
            this.gbBatch.Size = new System.Drawing.Size(200, 331);
            this.gbBatch.TabIndex = 15;
            this.gbBatch.TabStop = false;
            this.gbBatch.Text = "Batch";
            // 
            // btnClearBatch
            // 
            this.btnClearBatch.Location = new System.Drawing.Point(7, 302);
            this.btnClearBatch.Name = "btnClearBatch";
            this.btnClearBatch.Size = new System.Drawing.Size(187, 23);
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
            this.gbInput.Location = new System.Drawing.Point(2, 7);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(200, 331);
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
            this.pbResizeProgress.Location = new System.Drawing.Point(2, 344);
            this.pbResizeProgress.Name = "pbResizeProgress";
            this.pbResizeProgress.Size = new System.Drawing.Size(674, 23);
            this.pbResizeProgress.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 374);
            this.Controls.Add(this.pbResizeProgress);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.gbBatch);
            this.Controls.Add(this.gbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.gbResizeMode.ResumeLayout(false);
            this.gbResizeMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbCollisionAction.ResumeLayout(false);
            this.gbCollisionAction.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rbtnResizeModeStretch;
        private System.Windows.Forms.GroupBox gbResizeMode;
        private System.Windows.Forms.RadioButton rbtnResizeModeContain;
        private System.Windows.Forms.RadioButton rbtnResizeModeCover;
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
    }
}