using System.Data;
using PosSystem.Repositories;
using PosSystem.Configs;
using PosSystem.Utils;

namespace PosSystem.Services.Implement
{
    public class UserServiceImplement : IUserRepository
    {
        private readonly DBConnection dBConnection = new DBConnection();

        /// <summary>
        /// Return true if this credential has data in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateLogin(string username, string password)
        {
            DataTable users = dBConnection.ExecuteSqlCommand(GenerateCommand.GetAllWhereTwoColumn("[tblUsers]", "[User_Username]", username, "[User_Password]", password));
            
            return users.Rows.Count > 0;
        }
    }
}
