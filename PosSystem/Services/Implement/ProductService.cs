using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosSystem.Models;
using PosSystem.Repositories;
using PosSystem.Configs;
using System.Data.SqlClient;
using PosSystem.Utils;

namespace PosSystem.Services.Implement
{
    public class ProductService : IProductRepository
    {
        private DBConnection conn = DBConnection.GetInstance();

        public void DeleteBy(string barcode)
        {
            conn.connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM tblProducts WHERE Product_Barcode = {barcode}", conn.connection);
                SqlDataReader products = cmd.ExecuteReader();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public List<Product> FilterBy(string column, string value)
        {
            conn.connection.Open();
            List<Product> productLists = new List<Product>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.FilterByOneColumn("[tblProducts]", column, value), conn.connection);
                SqlDataReader products = cmd.ExecuteReader();

                while (products.Read())
                {
                    int id = int.Parse(products[0].ToString());
                    string productName = products[1].ToString();
                    int productBarcode = int.Parse(products[2].ToString());
                    decimal productPrice = decimal.Parse(products[3].ToString());
                    int productQuantity = int.Parse(products[4].ToString());
                    string productImage = products[5].ToString();

                    Product product = new Product(id, productName, productBarcode, productPrice, productQuantity, productImage);
                    productLists.Add(product);
                }
                products.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return productLists;
        }

        public List<Product> GetAll()
        {
            conn.connection.Open();
            List<Product> productLists = new List<Product>();

            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM tblProducts;", conn.connection);
                SqlDataReader products = cmd.ExecuteReader();

                while (products.Read())
                {
                    int id = int.Parse(products[0].ToString());
                    string productName = products[1].ToString();
                    int productBarcode = int.Parse(products[2].ToString());
                    decimal productPrice = decimal.Parse(products[3].ToString());
                    int productQuantity = int.Parse(products[4].ToString());
                    string productImage = products[5].ToString();

                    Product product = new Product(id, productName, productBarcode, productPrice, productQuantity, productImage);
                    productLists.Add(product);
                }
                products.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return productLists;
        }

        public void Save(Product product)
        {
            conn.connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.SaveProduct("tblProducts", product._ProductName, product._ProductBarcode, product._ProductPrice, product._ProductQuantity, product._ProductImage), conn.connection);
                SqlDataReader products = cmd.ExecuteReader();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public bool FindByBarcode(string barcode)
        {
            conn.connection.Open();
            List<Product> productLists = new List<Product>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.GetAllWhereOneColumn("tblProducts", "[Product_Barcode]", barcode), conn.connection);
                SqlDataReader products = cmd.ExecuteReader();

                while (products.Read())
                {
                    int id = int.Parse(products[0].ToString());
                    string productName = products[1].ToString();
                    int productBarcode = int.Parse(products[2].ToString());
                    decimal productPrice = decimal.Parse(products[3].ToString());
                    int productQuantity = int.Parse(products[4].ToString());
                    string productImage = products[5].ToString();

                    Product product = new Product(id, productName, productBarcode, productPrice, productQuantity, productImage);
                    productLists.Add(product);
                }
                products.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            if(productLists.Count > 0)
            {
                return false;
            }
            return true;
        }

        public void UpdateBy(Product product, string columnName)
        {
            conn.connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.UpdateProduct("tblProducts", product._ProductName, product._ProductBarcode, product._ProductPrice, product._ProductQuantity, product._ProductImage), conn.connection);
                SqlDataReader products = cmd.ExecuteReader();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
    }
}
