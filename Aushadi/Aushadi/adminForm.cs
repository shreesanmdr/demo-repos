using System;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }
        public Panel PanelContainer
        {
            get
            {
                return adminControlPanel;
            }
            set
            {
                adminControlPanel = value;
            }
        }
        public Panel PanelContainer2
        {
            get
            {
                return bodyPanel;
            }
            set
            {
                bodyPanel = value;
            }
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            medicineMarketing lin = new medicineMarketing();
            lin.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Add(lin);
            lin.BringToFront();
        }

        private void btnUserControls_Click(object sender, EventArgs e)
        {
            UserDataControl udc = new UserDataControl();
            udc.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Add(udc);
            udc.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            medicineEntry lin = new medicineEntry();
            lin.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Add(lin);
            lin.BringToFront();
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            medicineMarketing lin = new medicineMarketing();
            lin.Dock = DockStyle.Fill;
            PanelContainer2.Controls.Add(lin);
            lin.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportControl rptCtrl = new reportControl();
            rptCtrl.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(rptCtrl);
            rptCtrl.BringToFront();
        }

        private void btnBillReport_Click(object sender, EventArgs e)
        {
            invoiceReport rptCtrl = new invoiceReport();
            rptCtrl.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(rptCtrl);
            rptCtrl.BringToFront();
        }
    }
}
