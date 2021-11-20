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

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnStock.Cursor = Cursors.Hand;
        }

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            btnSale.Cursor = Cursors.Hand;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUser.Cursor = Cursors.Hand;
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            btnReport.Cursor = Cursors.Hand;
        }
    }
}