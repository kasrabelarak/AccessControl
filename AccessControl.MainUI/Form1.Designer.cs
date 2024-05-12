namespace AccessControl.MainUI
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
            PanelMenu = new Panel();
            TiaraButton = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            homeButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelTitle = new Panel();
            PanelDesktop = new Panel();
            textBox1 = new TextBox();
            PagePanel = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTitle.SuspendLayout();
            PanelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.Orange;
            PanelMenu.Controls.Add(TiaraButton);
            PanelMenu.Controls.Add(iconButton7);
            PanelMenu.Controls.Add(homeButton);
            PanelMenu.Controls.Add(iconButton1);
            PanelMenu.Controls.Add(pictureBox2);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Dock = DockStyle.Right;
            PanelMenu.Location = new Point(1289, 0);
            PanelMenu.Margin = new Padding(4, 3, 4, 3);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(195, 564);
            PanelMenu.TabIndex = 0;
            // 
            // TiaraButton
            // 
            TiaraButton.Dock = DockStyle.Top;
            TiaraButton.FlatAppearance.BorderSize = 0;
            TiaraButton.FlatStyle = FlatStyle.Flat;
            TiaraButton.Font = new Font("B Roya", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TiaraButton.ForeColor = Color.White;
            TiaraButton.IconChar = FontAwesome.Sharp.IconChar.Deviantart;
            TiaraButton.IconColor = Color.White;
            TiaraButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TiaraButton.IconSize = 30;
            TiaraButton.Location = new Point(0, 125);
            TiaraButton.Margin = new Padding(4, 3, 4, 3);
            TiaraButton.Name = "TiaraButton";
            TiaraButton.Size = new Size(195, 50);
            TiaraButton.TabIndex = 9;
            TiaraButton.Tag = "تیارا";
            TiaraButton.Text = "تیارا";
            TiaraButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            TiaraButton.UseVisualStyleBackColor = true;
            TiaraButton.Click += TiaraButton_Click;
            // 
            // iconButton7
            // 
            iconButton7.Dock = DockStyle.Bottom;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("B Roya", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 30;
            iconButton7.Location = new Point(0, 496);
            iconButton7.Margin = new Padding(4, 3, 4, 3);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(0, 0, 0, 23);
            iconButton7.Size = new Size(195, 68);
            iconButton7.TabIndex = 8;
            iconButton7.Tag = "خروج";
            iconButton7.Text = "خروج";
            iconButton7.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton7.UseVisualStyleBackColor = true;
            iconButton7.Click += iconButton7_Click;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("B Roya", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            homeButton.ForeColor = Color.White;
            homeButton.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            homeButton.IconColor = Color.White;
            homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeButton.IconSize = 30;
            homeButton.Location = new Point(0, 75);
            homeButton.Margin = new Padding(4, 3, 4, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(195, 50);
            homeButton.TabIndex = 3;
            homeButton.Tag = "خانه";
            homeButton.Text = "خانه";
            homeButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            homeButton.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(7, 3);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(70, 69);
            iconButton1.TabIndex = 2;
            iconButton1.Tag = "";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(122, 7);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.White;
            PanelTitle.Controls.Add(PanelDesktop);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(0, 0);
            PanelTitle.Margin = new Padding(4, 3, 4, 3);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(1289, 75);
            PanelTitle.TabIndex = 1;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.Orange;
            PanelDesktop.Controls.Add(textBox1);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(0, 0);
            PanelDesktop.Margin = new Padding(4, 3, 4, 3);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1289, 75);
            PanelDesktop.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Orange;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("B Roya", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1289, 45);
            textBox1.TabIndex = 0;
            textBox1.Text = "سامانه جامع اکسس کنترل دژبان";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PagePanel
            // 
            PagePanel.Location = new Point(0, 75);
            PagePanel.Margin = new Padding(4, 3, 4, 3);
            PagePanel.Name = "PagePanel";
            PagePanel.Size = new Size(1289, 489);
            PagePanel.TabIndex = 2;
            PagePanel.Paint += PagePanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 564);
            Controls.Add(PagePanel);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTitle.ResumeLayout(false);
            PanelDesktop.ResumeLayout(false);
            PanelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton homeButton;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton TiaraButton;
        private System.Windows.Forms.Panel PagePanel;
    }
}