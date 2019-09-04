namespace LBABodyRandomise
{
    partial class LBABodyRand
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LBABodyRand));
            this.lvItemList = new System.Windows.Forms.ListView();
            this.chPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOffset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFindLoc = new System.Windows.Forms.Button();
            this.lblBodyLocation = new System.Windows.Forms.Label();
            this.txtBodyLoc = new System.Windows.Forms.TextBox();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.btnRandomiseRange = new System.Windows.Forms.Button();
            this.gbSwap = new System.Windows.Forms.GroupBox();
            this.chkBtoA = new System.Windows.Forms.CheckBox();
            this.lblBtoA = new System.Windows.Forms.Label();
            this.lblSwap1 = new System.Windows.Forms.Label();
            this.lblSwap0 = new System.Windows.Forms.Label();
            this.btnSet1 = new System.Windows.Forms.Button();
            this.btnSet0 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.gbRandomRange = new System.Windows.Forms.GroupBox();
            this.txtRandomLast = new System.Windows.Forms.TextBox();
            this.lblRandomLast = new System.Windows.Forms.Label();
            this.lblRandomFirst = new System.Windows.Forms.Label();
            this.txtRandomFirst = new System.Windows.Forms.TextBox();
            this.btnReplaceRange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbReplaceRange = new System.Windows.Forms.GroupBox();
            this.txtReplaceLast = new System.Windows.Forms.TextBox();
            this.lblRangeLast = new System.Windows.Forms.Label();
            this.lblRangeFirst = new System.Windows.Forms.Label();
            this.txtReplaceFirst = new System.Windows.Forms.TextBox();
            this.gbSelectFile = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAutoSwap = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.gbSwap.SuspendLayout();
            this.gbRandomRange.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbReplaceRange.SuspendLayout();
            this.gbSelectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvItemList
            // 
            this.lvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosition,
            this.chOffset,
            this.chName});
            this.lvItemList.FullRowSelect = true;
            this.lvItemList.Location = new System.Drawing.Point(12, 41);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(550, 375);
            this.lvItemList.TabIndex = 0;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.Details;
            this.lvItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvItemList_KeyDown);
            // 
            // chPosition
            // 
            this.chPosition.Text = "Position";
            this.chPosition.Width = 61;
            // 
            // chOffset
            // 
            this.chOffset.Text = "Offset";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 65;
            // 
            // btnFindLoc
            // 
            this.btnFindLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindLoc.Location = new System.Drawing.Point(449, 11);
            this.btnFindLoc.Name = "btnFindLoc";
            this.btnFindLoc.Size = new System.Drawing.Size(101, 23);
            this.btnFindLoc.TabIndex = 5;
            this.btnFindLoc.Text = "Select";
            this.btnFindLoc.UseVisualStyleBackColor = true;
            this.btnFindLoc.Click += new System.EventHandler(this.btnFindLoc_Click);
            // 
            // lblBodyLocation
            // 
            this.lblBodyLocation.AutoSize = true;
            this.lblBodyLocation.Location = new System.Drawing.Point(6, 14);
            this.lblBodyLocation.Name = "lblBodyLocation";
            this.lblBodyLocation.Size = new System.Drawing.Size(71, 13);
            this.lblBodyLocation.TabIndex = 4;
            this.lblBodyLocation.Text = "HQR location";
            // 
            // txtBodyLoc
            // 
            this.txtBodyLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyLoc.Location = new System.Drawing.Point(83, 11);
            this.txtBodyLoc.Name = "txtBodyLoc";
            this.txtBodyLoc.Size = new System.Drawing.Size(360, 20);
            this.txtBodyLoc.TabIndex = 3;
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDefault.Location = new System.Drawing.Point(137, 312);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(107, 23);
            this.btnRestoreDefault.TabIndex = 6;
            this.btnRestoreDefault.Text = "Restore Default";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
            // 
            // btnRandomiseRange
            // 
            this.btnRandomiseRange.Location = new System.Drawing.Point(10, 45);
            this.btnRandomiseRange.Name = "btnRandomiseRange";
            this.btnRandomiseRange.Size = new System.Drawing.Size(204, 23);
            this.btnRandomiseRange.TabIndex = 7;
            this.btnRandomiseRange.Text = "Randomise";
            this.btnRandomiseRange.UseVisualStyleBackColor = true;
            this.btnRandomiseRange.Click += new System.EventHandler(this.btnRandomiseRange_Click);
            // 
            // gbSwap
            // 
            this.gbSwap.Controls.Add(this.chkBtoA);
            this.gbSwap.Controls.Add(this.lblBtoA);
            this.gbSwap.Controls.Add(this.lblSwap1);
            this.gbSwap.Controls.Add(this.lblSwap0);
            this.gbSwap.Controls.Add(this.btnSet1);
            this.gbSwap.Controls.Add(this.btnSet0);
            this.gbSwap.Controls.Add(this.btnSwap);
            this.gbSwap.Location = new System.Drawing.Point(19, 19);
            this.gbSwap.Name = "gbSwap";
            this.gbSwap.Size = new System.Drawing.Size(220, 117);
            this.gbSwap.TabIndex = 15;
            this.gbSwap.TabStop = false;
            this.gbSwap.Text = "Set item A to B";
            // 
            // chkBtoA
            // 
            this.chkBtoA.AutoSize = true;
            this.chkBtoA.Checked = true;
            this.chkBtoA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBtoA.Location = new System.Drawing.Point(196, 68);
            this.chkBtoA.Name = "chkBtoA";
            this.chkBtoA.Size = new System.Drawing.Size(15, 14);
            this.chkBtoA.TabIndex = 19;
            this.chkBtoA.UseVisualStyleBackColor = true;
            // 
            // lblBtoA
            // 
            this.lblBtoA.AutoSize = true;
            this.lblBtoA.Location = new System.Drawing.Point(6, 66);
            this.lblBtoA.Name = "lblBtoA";
            this.lblBtoA.Size = new System.Drawing.Size(76, 13);
            this.lblBtoA.TabIndex = 18;
            this.lblBtoA.Text = "Also set B to A";
            // 
            // lblSwap1
            // 
            this.lblSwap1.AutoSize = true;
            this.lblSwap1.Location = new System.Drawing.Point(6, 44);
            this.lblSwap1.Name = "lblSwap1";
            this.lblSwap1.Size = new System.Drawing.Size(137, 13);
            this.lblSwap1.TabIndex = 17;
            this.lblSwap1.Text = "Select an item and click set";
            // 
            // lblSwap0
            // 
            this.lblSwap0.AutoSize = true;
            this.lblSwap0.Location = new System.Drawing.Point(6, 20);
            this.lblSwap0.MinimumSize = new System.Drawing.Size(160, 0);
            this.lblSwap0.Name = "lblSwap0";
            this.lblSwap0.Size = new System.Drawing.Size(160, 13);
            this.lblSwap0.TabIndex = 16;
            this.lblSwap0.Text = "Select an item and click set";
            // 
            // btnSet1
            // 
            this.btnSet1.Location = new System.Drawing.Point(177, 39);
            this.btnSet1.Name = "btnSet1";
            this.btnSet1.Size = new System.Drawing.Size(34, 23);
            this.btnSet1.TabIndex = 15;
            this.btnSet1.Text = "Set";
            this.btnSet1.UseVisualStyleBackColor = true;
            this.btnSet1.Click += new System.EventHandler(this.btnSet1_Click);
            // 
            // btnSet0
            // 
            this.btnSet0.Location = new System.Drawing.Point(177, 15);
            this.btnSet0.Name = "btnSet0";
            this.btnSet0.Size = new System.Drawing.Size(34, 23);
            this.btnSet0.TabIndex = 14;
            this.btnSet0.Text = "Set";
            this.btnSet0.UseVisualStyleBackColor = true;
            this.btnSet0.Click += new System.EventHandler(this.btnSet0_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(102, 88);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(109, 23);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // gbRandomRange
            // 
            this.gbRandomRange.Controls.Add(this.txtRandomLast);
            this.gbRandomRange.Controls.Add(this.lblRandomLast);
            this.gbRandomRange.Controls.Add(this.lblRandomFirst);
            this.gbRandomRange.Controls.Add(this.txtRandomFirst);
            this.gbRandomRange.Controls.Add(this.btnRandomiseRange);
            this.gbRandomRange.Location = new System.Drawing.Point(19, 229);
            this.gbRandomRange.Name = "gbRandomRange";
            this.gbRandomRange.Size = new System.Drawing.Size(220, 77);
            this.gbRandomRange.TabIndex = 16;
            this.gbRandomRange.TabStop = false;
            this.gbRandomRange.Text = "Randomise Options";
            // 
            // txtRandomLast
            // 
            this.txtRandomLast.Location = new System.Drawing.Point(146, 19);
            this.txtRandomLast.Name = "txtRandomLast";
            this.txtRandomLast.Size = new System.Drawing.Size(68, 20);
            this.txtRandomLast.TabIndex = 26;
            // 
            // lblRandomLast
            // 
            this.lblRandomLast.AutoSize = true;
            this.lblRandomLast.Location = new System.Drawing.Point(113, 22);
            this.lblRandomLast.Name = "lblRandomLast";
            this.lblRandomLast.Size = new System.Drawing.Size(27, 13);
            this.lblRandomLast.TabIndex = 25;
            this.lblRandomLast.Text = "Last";
            // 
            // lblRandomFirst
            // 
            this.lblRandomFirst.AutoSize = true;
            this.lblRandomFirst.Location = new System.Drawing.Point(7, 22);
            this.lblRandomFirst.Name = "lblRandomFirst";
            this.lblRandomFirst.Size = new System.Drawing.Size(26, 13);
            this.lblRandomFirst.TabIndex = 24;
            this.lblRandomFirst.Text = "First";
            // 
            // txtRandomFirst
            // 
            this.txtRandomFirst.Location = new System.Drawing.Point(42, 19);
            this.txtRandomFirst.Name = "txtRandomFirst";
            this.txtRandomFirst.Size = new System.Drawing.Size(65, 20);
            this.txtRandomFirst.TabIndex = 23;
            // 
            // btnReplaceRange
            // 
            this.btnReplaceRange.Location = new System.Drawing.Point(10, 52);
            this.btnReplaceRange.Name = "btnReplaceRange";
            this.btnReplaceRange.Size = new System.Drawing.Size(204, 23);
            this.btnReplaceRange.TabIndex = 18;
            this.btnReplaceRange.Text = "Replace";
            this.btnReplaceRange.UseVisualStyleBackColor = true;
            this.btnReplaceRange.Click += new System.EventHandler(this.btnReplaceRange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(137, 342);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(107, 23);
            this.btnSaveAs.TabIndex = 20;
            this.btnSaveAs.Text = "SaveAs";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.txtSeconds);
            this.gbOptions.Controls.Add(this.btnAutoSwap);
            this.gbOptions.Controls.Add(this.gbReplaceRange);
            this.gbOptions.Controls.Add(this.btnRestoreDefault);
            this.gbOptions.Controls.Add(this.gbSwap);
            this.gbOptions.Controls.Add(this.btnSaveAs);
            this.gbOptions.Controls.Add(this.gbRandomRange);
            this.gbOptions.Controls.Add(this.btnSave);
            this.gbOptions.Location = new System.Drawing.Point(568, 34);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(257, 382);
            this.gbOptions.TabIndex = 21;
            this.gbOptions.TabStop = false;
            // 
            // gbReplaceRange
            // 
            this.gbReplaceRange.Controls.Add(this.txtReplaceLast);
            this.gbReplaceRange.Controls.Add(this.lblRangeLast);
            this.gbReplaceRange.Controls.Add(this.lblRangeFirst);
            this.gbReplaceRange.Controls.Add(this.txtReplaceFirst);
            this.gbReplaceRange.Controls.Add(this.btnReplaceRange);
            this.gbReplaceRange.Location = new System.Drawing.Point(19, 142);
            this.gbReplaceRange.Name = "gbReplaceRange";
            this.gbReplaceRange.Size = new System.Drawing.Size(220, 81);
            this.gbReplaceRange.TabIndex = 21;
            this.gbReplaceRange.TabStop = false;
            this.gbReplaceRange.Text = "Replace range";
            // 
            // txtReplaceLast
            // 
            this.txtReplaceLast.Location = new System.Drawing.Point(146, 26);
            this.txtReplaceLast.Name = "txtReplaceLast";
            this.txtReplaceLast.Size = new System.Drawing.Size(68, 20);
            this.txtReplaceLast.TabIndex = 22;
            // 
            // lblRangeLast
            // 
            this.lblRangeLast.AutoSize = true;
            this.lblRangeLast.Location = new System.Drawing.Point(113, 29);
            this.lblRangeLast.Name = "lblRangeLast";
            this.lblRangeLast.Size = new System.Drawing.Size(27, 13);
            this.lblRangeLast.TabIndex = 21;
            this.lblRangeLast.Text = "Last";
            // 
            // lblRangeFirst
            // 
            this.lblRangeFirst.AutoSize = true;
            this.lblRangeFirst.Location = new System.Drawing.Point(7, 29);
            this.lblRangeFirst.Name = "lblRangeFirst";
            this.lblRangeFirst.Size = new System.Drawing.Size(26, 13);
            this.lblRangeFirst.TabIndex = 20;
            this.lblRangeFirst.Text = "First";
            // 
            // txtReplaceFirst
            // 
            this.txtReplaceFirst.Location = new System.Drawing.Point(42, 26);
            this.txtReplaceFirst.Name = "txtReplaceFirst";
            this.txtReplaceFirst.Size = new System.Drawing.Size(65, 20);
            this.txtReplaceFirst.TabIndex = 19;
            // 
            // gbSelectFile
            // 
            this.gbSelectFile.Controls.Add(this.checkBox1);
            this.gbSelectFile.Controls.Add(this.btnFindLoc);
            this.gbSelectFile.Controls.Add(this.txtBodyLoc);
            this.gbSelectFile.Controls.Add(this.lblBodyLocation);
            this.gbSelectFile.Location = new System.Drawing.Point(12, -2);
            this.gbSelectFile.Name = "gbSelectFile";
            this.gbSelectFile.Size = new System.Drawing.Size(813, 37);
            this.gbSelectFile.TabIndex = 22;
            this.gbSelectFile.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(575, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Automatically detect filetype";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAutoSwap
            // 
            this.btnAutoSwap.Location = new System.Drawing.Point(67, 312);
            this.btnAutoSwap.Name = "btnAutoSwap";
            this.btnAutoSwap.Size = new System.Drawing.Size(59, 23);
            this.btnAutoSwap.TabIndex = 22;
            this.btnAutoSwap.Text = "Auto";
            this.btnAutoSwap.UseVisualStyleBackColor = true;
            this.btnAutoSwap.Click += new System.EventHandler(this.btnAutoSwap_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(19, 314);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(42, 20);
            this.txtSeconds.TabIndex = 23;
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // LBABodyRand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 423);
            this.Controls.Add(this.gbSelectFile);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.lvItemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LBABodyRand";
            this.Text = "LBABodyRand";
            this.Load += new System.EventHandler(this.LBABodyRand_Load);
            this.gbSwap.ResumeLayout(false);
            this.gbSwap.PerformLayout();
            this.gbRandomRange.ResumeLayout(false);
            this.gbRandomRange.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbReplaceRange.ResumeLayout(false);
            this.gbReplaceRange.PerformLayout();
            this.gbSelectFile.ResumeLayout(false);
            this.gbSelectFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvItemList;
        private System.Windows.Forms.Button btnFindLoc;
        private System.Windows.Forms.Label lblBodyLocation;
        private System.Windows.Forms.TextBox txtBodyLoc;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.Button btnRandomiseRange;
        private System.Windows.Forms.GroupBox gbSwap;
        private System.Windows.Forms.Label lblSwap1;
        private System.Windows.Forms.Label lblSwap0;
        private System.Windows.Forms.Button btnSet1;
        private System.Windows.Forms.Button btnSet0;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ColumnHeader chOffset;
        private System.Windows.Forms.ColumnHeader chPosition;
        private System.Windows.Forms.GroupBox gbRandomRange;
        private System.Windows.Forms.Button btnReplaceRange;
        private System.Windows.Forms.CheckBox chkBtoA;
        private System.Windows.Forms.Label lblBtoA;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbReplaceRange;
        private System.Windows.Forms.TextBox txtReplaceLast;
        private System.Windows.Forms.Label lblRangeLast;
        private System.Windows.Forms.Label lblRangeFirst;
        private System.Windows.Forms.TextBox txtReplaceFirst;
        private System.Windows.Forms.TextBox txtRandomLast;
        private System.Windows.Forms.Label lblRandomLast;
        private System.Windows.Forms.Label lblRandomFirst;
        private System.Windows.Forms.TextBox txtRandomFirst;
        private System.Windows.Forms.GroupBox gbSelectFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Button btnAutoSwap;
        private System.Windows.Forms.Timer tmrTick;
    }
}

