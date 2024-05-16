namespace AccessControl.TiaraUI
{
    partial class TiaraForm
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
            StaffGridPanel = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // StaffGridPanel
            // 
            StaffGridPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StaffGridPanel.BackColor = Color.Transparent;
            StaffGridPanel.Location = new Point(607, 339);
            StaffGridPanel.Margin = new Padding(4, 3, 4, 3);
            StaffGridPanel.Name = "StaffGridPanel";
            StaffGridPanel.Size = new Size(785, 296);
            StaffGridPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(975, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TiaraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1393, 637);
            Controls.Add(button1);
            Controls.Add(StaffGridPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TiaraForm";
            Text = "Form1";
            Load += TiaraForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel StaffGridPanel;
        private Button button1;
    }
}