using PosSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Repositories
{
    public interface ICrud<T> where T : class
    {
        public List<T> GetUsers();
    }
}
