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
            this.StaffGridPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StaffGridPanel
            // 
            this.StaffGridPanel.Location = new System.Drawing.Point(600, 401);
            this.StaffGridPanel.Name = "StaffGridPanel";
            this.StaffGridPanel.Size = new System.Drawing.Size(682, 252);
            this.StaffGridPanel.TabIndex = 0;
            // 
            // TiaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 653);
            this.Controls.Add(this.StaffGridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TiaraForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TiaraForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StaffGridPanel;
    }
}

