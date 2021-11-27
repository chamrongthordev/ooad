using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosSystem.Models;

namespace PosSystem.Repositories
{
    public interface IProductRepository: ICrud<Product>
    {
        bool FindByBarcode(string barcode);
    }
}
