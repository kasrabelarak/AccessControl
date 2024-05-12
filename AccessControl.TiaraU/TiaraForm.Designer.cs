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
            SuspendLayout();
            // 
            // StaffGridPanel
            // 
            StaffGridPanel.BackColor = Color.Transparent;
            StaffGridPanel.Location = new Point(582, 327);
            StaffGridPanel.Margin = new Padding(4, 3, 4, 3);
            StaffGridPanel.Name = "StaffGridPanel";
            StaffGridPanel.Size = new Size(824, 329);
            StaffGridPanel.TabIndex = 0;
            // 
            // TiaraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 753);
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
    }
}