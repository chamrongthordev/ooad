using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosSystem.Repositories;
using PosSystem.Services.Implement;

namespace PosSystem.Services
{
    public class ProductServiceInstance
    {
        private static ProductServiceInstance? _productService;
        public IProductRepository ProductRepository =  new ProductService();

        // defind singleton pattern
        private ProductServiceInstance(){}

        /// <summary>
        /// Get an instance object of UserService
        /// </summary>
        /// <returns></returns>
        public static ProductServiceInstance getInstance()
        {

            if (_productService == null)
            {
                _productService = new ProductServiceInstance();
            }

            return _productService;
        }
    }
}
