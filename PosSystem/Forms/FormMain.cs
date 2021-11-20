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

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.BackColor = Color.ForestGreen;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin().Show();
        }

        private void btnLoadStockForm_MouseHover(object sender, EventArgs e)
        {
            btnLoadStockForm.Cursor = Cursors.Hand;
        }
    }
}