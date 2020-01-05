namespace HotSBot
{
    partial class hotsBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hotsBot));
            this.button3 = new System.Windows.Forms.Button();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblBanner = new System.Windows.Forms.Label();
            this.picBoxMurky = new System.Windows.Forms.PictureBox();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lblMins = new System.Windows.Forms.Label();
            this.minsTBox = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.hoursTBox = new System.Windows.Forms.TextBox();
            this.topBorderPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMurky)).BeginInit();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(360, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 83);
            this.button3.TabIndex = 0;
            this.button3.Text = "Start Bot";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.topBorderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topBorderPanel.BackgroundImage")));
            this.topBorderPanel.Controls.Add(this.headerPanel);
            this.topBorderPanel.Controls.Add(this.picBoxMurky);
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(596, 82);
            this.topBorderPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.lblBanner);
            this.headerPanel.ForeColor = System.Drawing.Color.Crimson;
            this.headerPanel.Location = new System.Drawing.Point(162, 22);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(241, 43);
            this.headerPanel.TabIndex = 7;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBanner.Location = new System.Drawing.Point(3, 6);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(235, 25);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Welcome to ELO Hell :)";
            // 
            // picBoxMurky
            // 
            this.picBoxMurky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxMurky.BackgroundImage")));
            this.picBoxMurky.Location = new System.Drawing.Point(-7, 0);
            this.picBoxMurky.Name = "picBoxMurky";
            this.picBoxMurky.Size = new System.Drawing.Size(600, 82);
            this.picBoxMurky.TabIndex = 0;
            this.picBoxMurky.TabStop = false;
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStart.Controls.Add(this.rtbConsole);
            this.pnlStart.Controls.Add(this.vScrollBar2);
            this.pnlStart.Controls.Add(this.vScrollBar1);
            this.pnlStart.Controls.Add(this.lblMins);
            this.pnlStart.Controls.Add(this.minsTBox);
            this.pnlStart.Controls.Add(this.lblHours);
            this.pnlStart.Controls.Add(this.hoursTBox);
            this.pnlStart.Controls.Add(this.button3);
            this.pnlStart.ForeColor = System.Drawing.Color.Crimson;
            this.pnlStart.Location = new System.Drawing.Point(12, 88);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(550, 371);
            this.pnlStart.TabIndex = 3;
            this.pnlStart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.LightCyan;
            this.rtbConsole.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rtbConsole.Location = new System.Drawing.Point(124, 129);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(298, 96);
            this.rtbConsole.TabIndex = 7;
            this.rtbConsole.Text = "Ye";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(253, 74);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 27);
            this.vScrollBar2.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(253, 45);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 25);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Ink Free", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMins.ForeColor = System.Drawing.Color.White;
            this.lblMins.Location = new System.Drawing.Point(121, 74);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(72, 21);
            this.lblMins.TabIndex = 4;
            this.lblMins.Text = "Minutes:";
            this.lblMins.Click += new System.EventHandler(this.label3_Click);
            // 
            // minsTBox
            // 
            this.minsTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.minsTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.minsTBox.Location = new System.Drawing.Point(199, 74);
            this.minsTBox.Name = "minsTBox";
            this.minsTBox.Size = new System.Drawing.Size(60, 27);
            this.minsTBox.TabIndex = 3;
            this.minsTBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Ink Free", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(124, 44);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(56, 21);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours:";
            // 
            // hoursTBox
            // 
            this.hoursTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hoursTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.hoursTBox.Location = new System.Drawing.Point(199, 44);
            this.hoursTBox.Name = "hoursTBox";
            this.hoursTBox.Size = new System.Drawing.Size(60, 27);
            this.hoursTBox.TabIndex = 1;
            // 
            // hotsBot
            // 
            this.ClientSize = new System.Drawing.Size(556, 349);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.topBorderPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hotsBot";
            this.Text = "HotS Lowbie Farmer 1.0.3";
            this.Load += new System.EventHandler(this.hotsBot_Load);
            this.topBorderPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMurky)).EndInit();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStartParams;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Button btnStartBook;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.NumericUpDown nmrGameCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStartClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.PictureBox picBoxMurky;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox hoursTBox;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox minsTBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.RichTextBox rtbConsole;
    }
}

