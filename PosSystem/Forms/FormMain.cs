namespace PosSystem.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.DarkGreen;
        }
    }
}