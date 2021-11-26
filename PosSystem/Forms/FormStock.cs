using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosSystem.Utils;
using PosSystem.Models;
using PosSystem.Services;

namespace PosSystem.Forms
{
    public partial class FormStock : Form
    {
        private IProductService productService = IProductService.getInstance();
        private string saveDirectory = @"Image\product\";
        string fileSavePath = @"Image\no-image.png";
        public FormStock()
        {
            InitializeComponent();

        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.Cursor = Cursors.Hand;
        }

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            btnSale.Cursor = Cursors.Hand;
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMain().Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Hide();
            new FormUser().Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Cursor = Cursors.Hand;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new FormLogin().Show();
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Cursor = Cursors.Hand;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.Cursor = Cursors.Hand;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.Cursor = Cursors.Hand;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Cursor = Cursors.Hand;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.Cursor = Cursors.Hand;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtProductBarcode.Text = "";
            txtProductPrice.Text = "";
            txtProductQuantity.Text = "";
            pictureBoxProfile.Image = Image.FromFile(fileSavePath);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();

            if (txtProductName.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូល ឈ្មោះផលិតផល", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if (txtProductBarcode.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូលលេខ barcode", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if (txtProductPrice.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូលលេខ តម្លៃផលិតផល", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else if (txtProductQuantity.Text == "")
            {
                formMessageBoxInfo.SetInfo("សូមបញ្ចូលលេខ ចំនួនផលិតផល", "warning");
                formMessageBoxInfo.ShowDialog();
            }
        }
        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpg, *png) | *.png; *.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                string prefix = new Random().Next(1, 1000).ToString() + DateTime.Now.ToString().Replace(" ", "-").Replace("/", "-").Replace(":", "-");
                string fileName = prefix + Path.GetFileName(openFileDialog.FileName);
                fileSavePath = Path.Combine(saveDirectory, fileName);

                File.Copy(openFileDialog.FileName, fileSavePath, true);

                pictureBoxProfile.Image = Image.FromFile(fileSavePath);
            }
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            comboSearchBy.SelectedIndex = 0;
            _GetAllProducts();
        }

        // Get all users
        private void _GetAllProducts()
        {
            dgvStock.Rows.Clear();
            List<Product> products= productService.productRepository.GetAll();
            foreach (Product product in products)
            {
                Image picture;
                try
                {
                    picture = Image.FromFile(product._ProductImage);
                }
                catch (Exception)
                {
                    picture = Image.FromFile(fileSavePath);
                }

                string productName = product._ProductName;
                int productBarcode = product._ProductBarcode;
                decimal productPrice = product._ProductPrice;
                int productQuantity = product._ProductQuantity;


                dgvStock.Rows.Add(picture, productName, productBarcode, productPrice, productQuantity);
            }
        }

        private void txtSearchBox_MouseUp(object sender, MouseEventArgs e)
        {
            _FilterProduct();
        }

        private void _FilterProduct()
        {
            string columnName = "[Product_Name]";
            if(comboSearchBy.SelectedIndex == 0)
            {
                columnName = "[Product_Name]";
            }

            if(comboSearchBy.SelectedIndex == 1)
            {
                columnName = "[Product_Barcode]";
            }


            List<Product> products = productService.productRepository.FilterBy(columnName, txtSearchBox.Text);
            dgvStock.Rows.Clear();
            foreach (Product product in products)
            {
                Image picture;
                try
                {
                    picture = Image.FromFile(product._ProductImage);
                }
                catch (Exception)
                {
                    picture = Image.FromFile(fileSavePath);
                }

                dgvStock.Rows.Add(picture, product._ProductName, product._ProductBarcode, product._ProductPrice, product._ProductQuantity);
            }
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            _FilterProduct();
        }
    }
}
