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
            pictureBoxProfile.Image = Image.FromFile(@"Image\no-image.png");
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

            else
            {
                if (productService.productRepository.FindByBarcode(txtProductBarcode.Text) == false)
                {
                    FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                    _formMessageBoxInfo.SetInfo("លេខ barcode ត្រូវបានប្រើប្រាស់រួចរាល់ហើយ", "warning");
                    _formMessageBoxInfo.ShowDialog();
                }

                else
                {
                    Product product = new Product();
                    product._ProductName = txtProductName.Text;
                    product._ProductBarcode = int.Parse(txtProductBarcode.Text);
                    product._ProductPrice = decimal.Parse(txtProductPrice.Text);
                    product._ProductQuantity = int.Parse(txtProductQuantity.Text);
                    product._ProductImage = fileSavePath;
                    productService.productRepository.Save(product);
                    FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                    _formMessageBoxInfo.SetInfo("ទិន្នន័យនេះត្រូវបានបញ្ចូលដោយជោគជ័យ", "success");
                    _formMessageBoxInfo.ShowDialog();
                    _GetAllProducts();
                }
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

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            txtProductBarcode.Text = dgvStock.CurrentRow.Cells[2].Value.ToString();
            txtProductPrice.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
            txtProductQuantity.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();

            pictureBoxProfile.Image = (Bitmap)dgvStock.CurrentRow.Cells[0].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtProductBarcode.Text == "")
            {
                FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                formMessageBoxInfo.SetInfo("សូមជ្រើសរើសទិន្នន័យសម្រាប់ធ្វើការកែប្រែជាមុនសិន", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else
            {
                if (productService.productRepository.FindByBarcode(txtProductBarcode.Text) == true)
                {
                    FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                    _formMessageBoxInfo.SetInfo("សូមបំពេញលេខ barcode ឲ្យបានត្រឹមត្រូវ", "warning");
                    _formMessageBoxInfo.ShowDialog();
                }

                else
                {
                    Product product = new Product();
                    product._ProductName = txtProductName.Text;
                    product._ProductBarcode = int.Parse(txtProductBarcode.Text);
                    product._ProductPrice = decimal.Parse(txtProductPrice.Text);
                    product._ProductQuantity = int.Parse(txtProductQuantity.Text);
                    product._ProductImage = fileSavePath;
                    productService.productRepository.UpdateBy(product, txtProductBarcode.Text);
                    FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                    _formMessageBoxInfo.SetInfo("ទិន្នន័យនេះត្រូវបានកែប្រែដោយជោគជ័យ", "success");
                    _formMessageBoxInfo.ShowDialog();
                    _GetAllProducts();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductBarcode.Text == "")
            {
                FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                formMessageBoxInfo.SetInfo("សូមជ្រើសរើសទិន្នន័យជាមុនសិន ទើបអ្នកអាចលុបទិន្នន័យបាន", "warning");
                formMessageBoxInfo.ShowDialog();
            }

            else
            {
                if (productService.productRepository.FindByBarcode(txtProductBarcode.Text) == true)
                {
                    FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                    _formMessageBoxInfo.SetInfo("សូមជ្រើសរើសទិន្នន័យជាមុនសិនមុននឹងប្រតិបត្តិការណ៍លុប", "warning");
                    _formMessageBoxInfo.ShowDialog();
                }

                else
                {
                    FormMessageBoxConfirm formMessageBoxConfirm = new FormMessageBoxConfirm();
                    formMessageBoxConfirm.ShowDialog();
                    if (formMessageBoxConfirm.GetIsDeleted() == true)
                    {
                        productService.productRepository.DeleteBy(txtProductBarcode.Text);
                        FormMessageBoxInfo _formMessageBoxInfo = new FormMessageBoxInfo();
                        _formMessageBoxInfo.SetInfo("លោកអ្នកបានប្រតិបត្តិការណ៍លុបដោយជោគជ័យ", "warning");
                        _formMessageBoxInfo.ShowDialog();
                        _GetAllProducts();
                    }

                    else
                    {
                        formMessageBoxConfirm.Hide();
                    }
                }
            }
        }
    }
}
