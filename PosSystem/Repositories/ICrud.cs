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
        public List<T> GetAll();
        public List<T> FilterBy(string column, string value);
        public void Save(T TObject);
        void UpdateBy(T t, string columnName);

        void DeleteBy(string columnName);
    }
}
