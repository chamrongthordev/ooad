using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosSystem.Repositories;
using PosSystem.Services.Implement;

namespace PosSystem.Services
{
    public class IProductService
    {
        private static IProductService? _productService;
        public IProductRepository productRepository =  new ProductService();

        // defind singleton pattern
        private IProductService(){}

        /// <summary>
        /// Get an instance object of UserService
        /// </summary>
        /// <returns></returns>
        public static IProductService getInstance()
        {

            if (_productService == null)
            {
                _productService = new IProductService();
            }

            return _productService;
        }
    }
}
