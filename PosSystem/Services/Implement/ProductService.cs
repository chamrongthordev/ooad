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

        public void DeleteBy(string username)
        {
            throw new NotImplementedException();
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

        public void Save(Product TObject)
        {
            throw new NotImplementedException();
        }

        public void UpdateBy(User user, string username)
        {
            throw new NotImplementedException();
        }
    }
}
