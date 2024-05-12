using AccessControl.Shared;

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
            StaffGrid.TopLevel = false;
            StaffGrid.Parent = this.StaffGridPanel;
            //StaffGrid.Enabled = true;
            //StaffGrid.Visible = true;
            //StaffGrid.BringToFront();
         
            //StaffGrid.Parent = this.StaffGridPanel;

            this.StaffGridPanel.Controls.Add(StaffGrid);
            //this.StaffGridPanel.Tag = StaffGrid;
            StaffGrid.Show();
        }

    }
}