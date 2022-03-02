using System;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            medicineMarketing lin = new medicineMarketing();
            lin.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(lin);
            lin.BringToFront();
        }
    }
}
