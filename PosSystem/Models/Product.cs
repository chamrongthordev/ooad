using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string _ProductName { get; set; }
        public int _ProductBarcode { get; set; }
        public decimal _ProductPrice { get; set; }
        public int _ProductQuantity { get; set; }
        public string _ProductImage { get; set; }

        public Product(int Id, string productName, int productBarcode, decimal productPrice, int productQuantity, string productImage)
        {
            _ProductName = productName;
            _ProductBarcode = productBarcode;
            _ProductPrice = productPrice;
            _ProductQuantity = productQuantity;
            _ProductImage = productImage;
        }
    }
}
