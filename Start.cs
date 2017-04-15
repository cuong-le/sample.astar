using System;
using System.Windows.Forms;

namespace CGS.Sample.AStar
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            VerticalScroll.Visible = false;
            HorizontalScroll.Visible = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Hide();
            new Table(this).Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
