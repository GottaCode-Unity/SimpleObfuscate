namespace SimpleObfuscate
{
    partial class Status
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
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblKeywordStatus = new System.Windows.Forms.Label();
            this.pbProgressKeywords = new System.Windows.Forms.ProgressBar();
            this.pbProgressClass = new System.Windows.Forms.ProgressBar();
            this.lblClassStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(12, 25);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(270, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.Location = new System.Drawing.Point(12, 9);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(61, 13);
            this.lblDoing.TabIndex = 1;
            this.lblDoing.Text = "Initializing...";
            // 
            // lblKeywordStatus
            // 
            this.lblKeywordStatus.AutoSize = true;
            this.lblKeywordStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywordStatus.Location = new System.Drawing.Point(12, 60);
            this.lblKeywordStatus.Name = "lblKeywordStatus";
            this.lblKeywordStatus.Size = new System.Drawing.Size(52, 13);
            this.lblKeywordStatus.TabIndex = 2;
            this.lblKeywordStatus.Text = "Waiting...";
            // 
            // pbProgressKeywords
            // 
            this.pbProgressKeywords.Location = new System.Drawing.Point(12, 76);
            this.pbProgressKeywords.Name = "pbProgressKeywords";
            this.pbProgressKeywords.Size = new System.Drawing.Size(270, 23);
            this.pbProgressKeywords.TabIndex = 3;
            // 
            // pbProgressClass
            // 
            this.pbProgressClass.Location = new System.Drawing.Point(12, 125);
            this.pbProgressClass.Name = "pbProgressClass";
            this.pbProgressClass.Size = new System.Drawing.Size(270, 23);
            this.pbProgressClass.TabIndex = 5;
            // 
            // lblClassStatus
            // 
            this.lblClassStatus.AutoSize = true;
            this.lblClassStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassStatus.Location = new System.Drawing.Point(12, 109);
            this.lblClassStatus.Name = "lblClassStatus";
            this.lblClassStatus.Size = new System.Drawing.Size(52, 13);
            this.lblClassStatus.TabIndex = 4;
            this.lblClassStatus.Text = "Waiting...";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 162);
            this.Controls.Add(this.pbProgressClass);
            this.Controls.Add(this.lblClassStatus);
            this.Controls.Add(this.pbProgressKeywords);
            this.Controls.Add(this.lblKeywordStatus);
            this.Controls.Add(this.lblDoing);
            this.Controls.Add(this.pbProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Status";
            this.Text = "Obfuscating...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Status_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Label lblKeywordStatus;
        private System.Windows.Forms.ProgressBar pbProgressKeywords;
        private System.Windows.Forms.ProgressBar pbProgressClass;
        private System.Windows.Forms.Label lblClassStatus;
    }
}