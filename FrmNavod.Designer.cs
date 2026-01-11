namespace FootbalGamble
{
    partial class FrmNavod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNavod));
            this.lblNavodTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNavodTxt
            // 
            this.lblNavodTxt.AutoSize = true;
            this.lblNavodTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNavodTxt.Location = new System.Drawing.Point(12, 9);
            this.lblNavodTxt.Name = "lblNavodTxt";
            this.lblNavodTxt.Size = new System.Drawing.Size(46, 18);
            this.lblNavodTxt.TabIndex = 0;
            this.lblNavodTxt.Text = "label1";
            this.lblNavodTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmNavod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 522);
            this.Controls.Add(this.lblNavodTxt);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNavod";
            this.Text = "FrmNavod";
            this.Load += new System.EventHandler(this.FrmNavod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNavodTxt;
    }
}