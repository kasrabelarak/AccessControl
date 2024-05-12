using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl.TiaraUI
{
    public partial class TiaraForm : Form
    {
        public TiaraForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void TiaraForm_Load(object sender, EventArgs e)
        {
            LoadStaffGrid();
        }
        public void LoadStaffGrid()
        {
            if (this.StaffGridPanel.Controls.Count > 0)
                this.StaffGridPanel.Controls.RemoveAt(0);

            Form StaffGrid = new StaffGrid();
            StaffGrid.Dock = DockStyle.Fill;
            this.StaffGridPanel.Controls.Add(StaffGrid);
            this.StaffGridPanel.Tag = StaffGrid;
            StaffGrid.Show();
        }

    }
}
