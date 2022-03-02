using System;
using System.Windows.Forms;

namespace Aushadi
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PanelContainer
        {
            get
            {
                return mainPanel;
            }
            set
            {
                mainPanel = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            logIn lin = new logIn();
            lin.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(lin);
            lin.BringToFront();

        }
        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            logIn lin = new logIn();
            lin.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(lin);
            lin.BringToFront();
        }
    }
}
