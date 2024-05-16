using AccessControl.Shared;
using AccessControl.TiaraManager;

namespace AccessControl.TiaraUI
{
    public partial class TiaraForm : Form
    {

        private readonly TiaraDevice tiaraDevice;
        public TiaraForm()
        {
            tiaraDevice = new TiaraDevice();
            InitializeComponent();

        }

        private async void TiaraForm_Load(object sender, EventArgs e)
        {
            await GetOnlineDevices();
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
            StaffGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            //StaffGrid.Size = new Size(StaffGridPanel.Width, StaffGridPanel.Height);
            //StaffGrid.Location = new Point(StaffGridPanel.Location.X, StaffGridPanel.Location.Y) ;
            //StaffGrid.Enabled = true;
            //StaffGrid.Visible = true;
            //StaffGrid.BringToFront();

            //StaffGrid.Parent = this.StaffGridPanel;

            this.StaffGridPanel.Controls.Add(StaffGrid);
            //this.StaffGridPanel.Tag = StaffGrid;
            StaffGrid.Show();

        }

        public async Task GetOnlineDevices()
        {
            var onlineDevices = await tiaraDevice.Connect();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await tiaraDevice.Get();
        }
    }
}