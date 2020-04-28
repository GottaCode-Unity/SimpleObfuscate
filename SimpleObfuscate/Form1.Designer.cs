namespace SimpleObfuscate
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInputClasses = new System.Windows.Forms.GroupBox();
            this.lblClassEnding = new System.Windows.Forms.Label();
            this.tbEnding = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnRemoveClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.lbInputClasses = new System.Windows.Forms.ListBox();
            this.gbObfConfig = new System.Windows.Forms.GroupBox();
            this.nudNameCount = new System.Windows.Forms.NumericUpDown();
            this.btnViewPutput = new System.Windows.Forms.Button();
            this.btnStartObfuscator = new System.Windows.Forms.Button();
            this.btnRemoveKeyword = new System.Windows.Forms.Button();
            this.lbKeywords = new System.Windows.Forms.ListBox();
            this.btnNewKeyword = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.tbClassPreview = new System.Windows.Forms.RichTextBox();
            this.tbTurboMode = new System.Windows.Forms.CheckBox();
            this.gbInputClasses.SuspendLayout();
            this.gbObfConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNameCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInputClasses
            // 
            this.gbInputClasses.Controls.Add(this.lblClassEnding);
            this.gbInputClasses.Controls.Add(this.tbEnding);
            this.gbInputClasses.Controls.Add(this.btnAddFolder);
            this.gbInputClasses.Controls.Add(this.btnRemoveClass);
            this.gbInputClasses.Controls.Add(this.btnAddClass);
            this.gbInputClasses.Controls.Add(this.lbInputClasses);
            this.gbInputClasses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbInputClasses.Location = new System.Drawing.Point(13, 13);
            this.gbInputClasses.Name = "gbInputClasses";
            this.gbInputClasses.Size = new System.Drawing.Size(390, 216);
            this.gbInputClasses.TabIndex = 0;
            this.gbInputClasses.TabStop = false;
            this.gbInputClasses.Text = "Input Classes";
            // 
            // lblClassEnding
            // 
            this.lblClassEnding.AutoSize = true;
            this.lblClassEnding.Location = new System.Drawing.Point(277, 167);
            this.lblClassEnding.Name = "lblClassEnding";
            this.lblClassEnding.Size = new System.Drawing.Size(70, 13);
            this.lblClassEnding.TabIndex = 5;
            this.lblClassEnding.Text = "Class ending:";
            // 
            // tbEnding
            // 
            this.tbEnding.BackColor = System.Drawing.Color.Gainsboro;
            this.tbEnding.Location = new System.Drawing.Point(277, 184);
            this.tbEnding.Name = "tbEnding";
            this.tbEnding.Size = new System.Drawing.Size(106, 20);
            this.tbEnding.TabIndex = 4;
            this.tbEnding.TextChanged += new System.EventHandler(this.tbEnding_TextChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddFolder.Location = new System.Drawing.Point(277, 20);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(106, 37);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "Add source folder...";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveClass.Location = new System.Drawing.Point(278, 92);
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(106, 23);
            this.btnRemoveClass.TabIndex = 2;
            this.btnRemoveClass.Text = "Remove selected";
            this.btnRemoveClass.UseVisualStyleBackColor = true;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddClass.Location = new System.Drawing.Point(278, 63);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(106, 23);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Add class...";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // lbInputClasses
            // 
            this.lbInputClasses.BackColor = System.Drawing.Color.DarkGray;
            this.lbInputClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInputClasses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInputClasses.FormattingEnabled = true;
            this.lbInputClasses.Location = new System.Drawing.Point(7, 20);
            this.lbInputClasses.Name = "lbInputClasses";
            this.lbInputClasses.Size = new System.Drawing.Size(264, 184);
            this.lbInputClasses.TabIndex = 0;
            this.lbInputClasses.SelectedIndexChanged += new System.EventHandler(this.lbInputClasses_SelectedIndexChanged);
            // 
            // gbObfConfig
            // 
            this.gbObfConfig.Controls.Add(this.tbTurboMode);
            this.gbObfConfig.Controls.Add(this.nudNameCount);
            this.gbObfConfig.Controls.Add(this.btnViewPutput);
            this.gbObfConfig.Controls.Add(this.btnStartObfuscator);
            this.gbObfConfig.Controls.Add(this.btnRemoveKeyword);
            this.gbObfConfig.Controls.Add(this.lbKeywords);
            this.gbObfConfig.Controls.Add(this.btnNewKeyword);
            this.gbObfConfig.Controls.Add(this.tbKeyword);
            this.gbObfConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbObfConfig.Location = new System.Drawing.Point(409, 13);
            this.gbObfConfig.Name = "gbObfConfig";
            this.gbObfConfig.Size = new System.Drawing.Size(386, 216);
            this.gbObfConfig.TabIndex = 1;
            this.gbObfConfig.TabStop = false;
            this.gbObfConfig.Text = "Obfuscation Config";
            // 
            // nudNameCount
            // 
            this.nudNameCount.BackColor = System.Drawing.Color.Gainsboro;
            this.nudNameCount.Location = new System.Drawing.Point(277, 74);
            this.nudNameCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNameCount.Name = "nudNameCount";
            this.nudNameCount.Size = new System.Drawing.Size(103, 20);
            this.nudNameCount.TabIndex = 6;
            this.nudNameCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnViewPutput
            // 
            this.btnViewPutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewPutput.Location = new System.Drawing.Point(277, 166);
            this.btnViewPutput.Name = "btnViewPutput";
            this.btnViewPutput.Size = new System.Drawing.Size(103, 38);
            this.btnViewPutput.TabIndex = 5;
            this.btnViewPutput.Text = "View output classes";
            this.btnViewPutput.UseVisualStyleBackColor = true;
            this.btnViewPutput.Click += new System.EventHandler(this.btnViewPutput_Click);
            // 
            // btnStartObfuscator
            // 
            this.btnStartObfuscator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartObfuscator.Location = new System.Drawing.Point(277, 124);
            this.btnStartObfuscator.Name = "btnStartObfuscator";
            this.btnStartObfuscator.Size = new System.Drawing.Size(103, 36);
            this.btnStartObfuscator.TabIndex = 4;
            this.btnStartObfuscator.Text = "Start Obfuscater";
            this.btnStartObfuscator.UseVisualStyleBackColor = true;
            this.btnStartObfuscator.Click += new System.EventHandler(this.btnStartObfuscator_Click);
            // 
            // btnRemoveKeyword
            // 
            this.btnRemoveKeyword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveKeyword.Location = new System.Drawing.Point(276, 46);
            this.btnRemoveKeyword.Name = "btnRemoveKeyword";
            this.btnRemoveKeyword.Size = new System.Drawing.Size(104, 21);
            this.btnRemoveKeyword.TabIndex = 3;
            this.btnRemoveKeyword.Text = "Remove Keyword";
            this.btnRemoveKeyword.UseVisualStyleBackColor = true;
            this.btnRemoveKeyword.Click += new System.EventHandler(this.btnRemoveKeyword_Click);
            // 
            // lbKeywords
            // 
            this.lbKeywords.BackColor = System.Drawing.Color.DarkGray;
            this.lbKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbKeywords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbKeywords.FormattingEnabled = true;
            this.lbKeywords.Location = new System.Drawing.Point(7, 46);
            this.lbKeywords.Name = "lbKeywords";
            this.lbKeywords.Size = new System.Drawing.Size(263, 158);
            this.lbKeywords.TabIndex = 2;
            // 
            // btnNewKeyword
            // 
            this.btnNewKeyword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewKeyword.Location = new System.Drawing.Point(276, 19);
            this.btnNewKeyword.Name = "btnNewKeyword";
            this.btnNewKeyword.Size = new System.Drawing.Size(104, 21);
            this.btnNewKeyword.TabIndex = 1;
            this.btnNewKeyword.Text = "Add Keyword";
            this.btnNewKeyword.UseVisualStyleBackColor = true;
            this.btnNewKeyword.Click += new System.EventHandler(this.btnNewKeyword_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.BackColor = System.Drawing.Color.DarkGray;
            this.tbKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKeyword.Location = new System.Drawing.Point(7, 20);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(263, 20);
            this.tbKeyword.TabIndex = 0;
            this.tbKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyword_KeyDown);
            // 
            // tbClassPreview
            // 
            this.tbClassPreview.BackColor = System.Drawing.Color.Black;
            this.tbClassPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClassPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbClassPreview.Location = new System.Drawing.Point(12, 235);
            this.tbClassPreview.Name = "tbClassPreview";
            this.tbClassPreview.ReadOnly = true;
            this.tbClassPreview.Size = new System.Drawing.Size(783, 394);
            this.tbClassPreview.TabIndex = 2;
            this.tbClassPreview.Text = "";
            this.tbClassPreview.WordWrap = false;
            this.tbClassPreview.ZoomFactor = 1.2F;
            // 
            // tbTurboMode
            // 
            this.tbTurboMode.AutoSize = true;
            this.tbTurboMode.Location = new System.Drawing.Point(277, 101);
            this.tbTurboMode.Name = "tbTurboMode";
            this.tbTurboMode.Size = new System.Drawing.Size(84, 17);
            this.tbTurboMode.TabIndex = 7;
            this.tbTurboMode.Text = "Turbo Mode";
            this.tbTurboMode.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(807, 641);
            this.Controls.Add(this.tbClassPreview);
            this.Controls.Add(this.gbObfConfig);
            this.Controls.Add(this.gbInputClasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Simple Obfuscate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.gbInputClasses.ResumeLayout(false);
            this.gbInputClasses.PerformLayout();
            this.gbObfConfig.ResumeLayout(false);
            this.gbObfConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNameCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputClasses;
        private System.Windows.Forms.Button btnRemoveClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ListBox lbInputClasses;
        private System.Windows.Forms.GroupBox gbObfConfig;
        private System.Windows.Forms.RichTextBox tbClassPreview;
        private System.Windows.Forms.ListBox lbKeywords;
        private System.Windows.Forms.Button btnNewKeyword;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btnViewPutput;
        private System.Windows.Forms.Button btnStartObfuscator;
        private System.Windows.Forms.Button btnRemoveKeyword;
        private System.Windows.Forms.NumericUpDown nudNameCount;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label lblClassEnding;
        private System.Windows.Forms.TextBox tbEnding;
        private System.Windows.Forms.CheckBox tbTurboMode;
    }
}

