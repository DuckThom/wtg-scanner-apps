namespace BalieScanner
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.scanButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laser1 = new datalogic.datacapture.Laser();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.nameMenuItem = new System.Windows.Forms.MenuItem();
            this.ipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.Color.White;
            this.scanButton.Location = new System.Drawing.Point(3, 55);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(232, 37);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "1: Scannen";
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(3, 98);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(232, 37);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "2: Verzenden";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(3, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(232, 37);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Escape: Afsluiten";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 455);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.nameMenuItem);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "IP Adres";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // nameMenuItem
            // 
            this.nameMenuItem.Enabled = false;
            this.nameMenuItem.Text = "Name";
            // 
            // ipLabel
            // 
            this.ipLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.ipLabel.ForeColor = System.Drawing.Color.White;
            this.ipLabel.Location = new System.Drawing.Point(3, 32);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(232, 20);
            this.ipLabel.Text = "IP: ";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Balie Scanner : Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private datalogic.datacapture.Laser laser1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.MenuItem nameMenuItem;
    }
}