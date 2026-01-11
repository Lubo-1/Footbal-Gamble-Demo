namespace FootbalGamble
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPenize = new System.Windows.Forms.Label();
            this.numSazeni = new System.Windows.Forms.NumericUpDown();
            this.lblCil = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblSkoreZapasu = new System.Windows.Forms.Label();
            this.btnRemiza = new System.Windows.Forms.Button();
            this.listViewTabulkaLigy = new System.Windows.Forms.ListView();
            this.cTeams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblZapasy = new System.Windows.Forms.Label();
            this.levlBar = new System.Windows.Forms.ProgressBar();
            this.lblLevl = new System.Windows.Forms.Label();
            this.lblLevlZprava = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNavod = new System.Windows.Forms.Button();
            this.lblLevlNazev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSazeni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(183, 248);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "kontrola btn";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.lbl2.Location = new System.Drawing.Point(131, 118);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(211, 26);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Vyhra/Nevyhra/Remiza";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(42, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 37);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Team 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(337, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 37);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Team 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(186, 315);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(91, 37);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Potvrdit";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(397, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 37);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Další";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPenize
            // 
            this.lblPenize.AutoSize = true;
            this.lblPenize.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F);
            this.lblPenize.Location = new System.Drawing.Point(398, 0);
            this.lblPenize.Name = "lblPenize";
            this.lblPenize.Size = new System.Drawing.Size(96, 38);
            this.lblPenize.TabIndex = 7;
            this.lblPenize.Text = "Penize";
            // 
            // numSazeni
            // 
            this.numSazeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numSazeni.InterceptArrowKeys = false;
            this.numSazeni.Location = new System.Drawing.Point(137, 277);
            this.numSazeni.Name = "numSazeni";
            this.numSazeni.Size = new System.Drawing.Size(205, 32);
            this.numSazeni.TabIndex = 8;
            this.numSazeni.ValueChanged += new System.EventHandler(this.numSazeni_ValueChanged);
            // 
            // lblCil
            // 
            this.lblCil.AutoSize = true;
            this.lblCil.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCil.Location = new System.Drawing.Point(165, 73);
            this.lblCil.Name = "lblCil";
            this.lblCil.Size = new System.Drawing.Size(54, 26);
            this.lblCil.TabIndex = 9;
            this.lblCil.Text = "score";
            // 
            // btnResetGame
            // 
            this.btnResetGame.Enabled = false;
            this.btnResetGame.Location = new System.Drawing.Point(12, 360);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(105, 34);
            this.btnResetGame.TabIndex = 10;
            this.btnResetGame.Text = "Reset game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lblSkoreZapasu
            // 
            this.lblSkoreZapasu.AutoSize = true;
            this.lblSkoreZapasu.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.lblSkoreZapasu.Location = new System.Drawing.Point(203, 144);
            this.lblSkoreZapasu.Name = "lblSkoreZapasu";
            this.lblSkoreZapasu.Size = new System.Drawing.Size(56, 26);
            this.lblSkoreZapasu.TabIndex = 12;
            this.lblSkoreZapasu.Text = "-- : --";
            // 
            // btnRemiza
            // 
            this.btnRemiza.Location = new System.Drawing.Point(186, 208);
            this.btnRemiza.Name = "btnRemiza";
            this.btnRemiza.Size = new System.Drawing.Size(91, 37);
            this.btnRemiza.TabIndex = 13;
            this.btnRemiza.Text = "Remiza";
            this.btnRemiza.UseVisualStyleBackColor = true;
            this.btnRemiza.Click += new System.EventHandler(this.btnRemiza_Click);
            // 
            // listViewTabulkaLigy
            // 
            this.listViewTabulkaLigy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTeams,
            this.cPoints});
            this.listViewTabulkaLigy.HideSelection = false;
            this.listViewTabulkaLigy.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTabulkaLigy.Location = new System.Drawing.Point(12, 19);
            this.listViewTabulkaLigy.Name = "listViewTabulkaLigy";
            this.listViewTabulkaLigy.Size = new System.Drawing.Size(285, 375);
            this.listViewTabulkaLigy.TabIndex = 14;
            this.listViewTabulkaLigy.UseCompatibleStateImageBehavior = false;
            this.listViewTabulkaLigy.View = System.Windows.Forms.View.Details;
            // 
            // cTeams
            // 
            this.cTeams.Text = "Teams";
            this.cTeams.Width = 108;
            // 
            // cPoints
            // 
            this.cPoints.Text = "Points";
            // 
            // lblZapasy
            // 
            this.lblZapasy.AutoSize = true;
            this.lblZapasy.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.lblZapasy.Location = new System.Drawing.Point(232, 19);
            this.lblZapasy.Name = "lblZapasy";
            this.lblZapasy.Size = new System.Drawing.Size(65, 26);
            this.lblZapasy.TabIndex = 15;
            this.lblZapasy.Text = "0 / 30";
            // 
            // levlBar
            // 
            this.levlBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.levlBar.Location = new System.Drawing.Point(107, 3);
            this.levlBar.Name = "levlBar";
            this.levlBar.Size = new System.Drawing.Size(257, 35);
            this.levlBar.TabIndex = 16;
            this.levlBar.Click += new System.EventHandler(this.levlBar_Click);
            // 
            // lblLevl
            // 
            this.lblLevl.AutoSize = true;
            this.lblLevl.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLevl.Location = new System.Drawing.Point(198, 3);
            this.lblLevl.Name = "lblLevl";
            this.lblLevl.Size = new System.Drawing.Size(79, 32);
            this.lblLevl.TabIndex = 17;
            this.lblLevl.Text = "Level: ";
            // 
            // lblLevlZprava
            // 
            this.lblLevlZprava.AutoSize = true;
            this.lblLevlZprava.Location = new System.Drawing.Point(337, 41);
            this.lblLevlZprava.Name = "lblLevlZprava";
            this.lblLevlZprava.Size = new System.Drawing.Size(27, 13);
            this.lblLevlZprava.TabIndex = 18;
            this.lblLevlZprava.Text = "+-xp";
            this.lblLevlZprava.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLevlNazev);
            this.groupBox1.Controls.Add(this.btnRemiza);
            this.groupBox1.Controls.Add(this.lblLevlZprava);
            this.groupBox1.Controls.Add(this.lblSkoreZapasu);
            this.groupBox1.Controls.Add(this.lblLevl);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblCil);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.levlBar);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.numSazeni);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblPenize);
            this.groupBox1.Location = new System.Drawing.Point(303, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 375);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnNavod
            // 
            this.btnNavod.Location = new System.Drawing.Point(247, 359);
            this.btnNavod.Name = "btnNavod";
            this.btnNavod.Size = new System.Drawing.Size(50, 35);
            this.btnNavod.TabIndex = 20;
            this.btnNavod.Text = "?";
            this.btnNavod.UseVisualStyleBackColor = true;
            this.btnNavod.Click += new System.EventHandler(this.btnNavod_Click);
            // 
            // lblLevlNazev
            // 
            this.lblLevlNazev.AutoSize = true;
            this.lblLevlNazev.Location = new System.Drawing.Point(104, 41);
            this.lblLevlNazev.Name = "lblLevlNazev";
            this.lblLevlNazev.Size = new System.Drawing.Size(51, 13);
            this.lblLevlNazev.TabIndex = 19;
            this.lblLevlNazev.Text = "Novaček";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 402);
            this.Controls.Add(this.btnNavod);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblZapasy);
            this.Controls.Add(this.listViewTabulkaLigy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Football Gamble Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSazeni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPenize;
        private System.Windows.Forms.NumericUpDown numSazeni;
        private System.Windows.Forms.Label lblCil;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lblSkoreZapasu;
        private System.Windows.Forms.Button btnRemiza;
        private System.Windows.Forms.ListView listViewTabulkaLigy;
        private System.Windows.Forms.ColumnHeader cTeams;
        private System.Windows.Forms.ColumnHeader cPoints;
        private System.Windows.Forms.Label lblZapasy;
        private System.Windows.Forms.ProgressBar levlBar;
        private System.Windows.Forms.Label lblLevl;
        private System.Windows.Forms.Label lblLevlZprava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNavod;
        private System.Windows.Forms.Label lblLevlNazev;
    }
}

