using PosSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Repositories
{
    public interface IUserRepository:ICrud<User>
    {
        bool ValidateLogin(string username, string password);
        List<User> FindUsername(string username);
    }
}
