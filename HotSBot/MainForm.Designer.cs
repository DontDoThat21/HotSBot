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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStartClick = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnStartClick);
            this.panel2.Location = new System.Drawing.Point(12, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 239);
            this.panel2.TabIndex = 0;
            // 
            // btnStartClick
            // 
            this.btnStartClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnStartClick.Location = new System.Drawing.Point(309, 192);
            this.btnStartClick.Name = "btnStartClick";
            this.btnStartClick.Size = new System.Drawing.Size(75, 31);
            this.btnStartClick.TabIndex = 0;
            this.btnStartClick.Text = "button1";
            this.btnStartClick.UseVisualStyleBackColor = true;
            this.btnStartClick.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // hotsBot
            // 
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.panel2);
            this.Name = "hotsBot";
            this.Load += new System.EventHandler(this.hotsBot_Load);
            this.panel2.ResumeLayout(false);
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
    }
}

