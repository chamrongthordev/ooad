using System.Data;
using PosSystem.Repositories;
using PosSystem.Configs;
using PosSystem.Utils;
using PosSystem.Models;
using System.Data.SqlClient;

namespace PosSystem.Services.Implement
{
    public class UserServiceImplement : IUserRepository
    {
        private readonly DBConnection conn = DBConnection.GetInstance();
        /// <summary>
        /// Get all users as DataTable type
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.GetAllWhereOneColumn("[tblUsers]", "[User_Status]", "1"), conn.connection);
                SqlDataReader users = cmd.ExecuteReader();

                while (users.Read())
                {
                    int id = int.Parse(users[0].ToString());
                    string userFirstName = users[1].ToString();
                    string userLastName = users[2].ToString();
                    string userUsername = users[3].ToString();
                    string userPassword = users[4].ToString();
                    string userGender = users[5].ToString();
                    string userRole = users[6].ToString();
                    string userImage = users[7].ToString();
                    bool userStatus = bool.Parse(users[8].ToString());

                    User user = new User(id, userFirstName, userLastName, userUsername, userPassword, userGender, userRole, userImage, userStatus);
                    usersList.Add(user);
                }
                users.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return usersList;
        }

        public List<User> FilterUsers(string column, string value)
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.FilterByTwoColumn("[tblUsers]", column, value, "[User_Status]", "1"), conn.connection);
                SqlDataReader users = cmd.ExecuteReader();

                while (users.Read())
                {
                    int id = int.Parse(users[0].ToString());
                    string userFirstName = users[1].ToString();
                    string userLastName = users[2].ToString();
                    string userUsername = users[3].ToString();
                    string userPassword = users[4].ToString();
                    string userGender = users[5].ToString();
                    string userRole = users[6].ToString();
                    string userImage = users[7].ToString();
                    bool userStatus = bool.Parse(users[8].ToString());

                    User user = new User(id, userFirstName, userLastName, userUsername, userPassword, userGender, userRole, userImage, userStatus);
                    usersList.Add(user);
                }
                users.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return usersList;
        }

        /// <summary>
        /// Return true if this credential has data in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateLogin(string username, string password)
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.GetAllWhereThreeColumn("[tblUsers]", "[User_Username]", username, "[User_Password]", password, "[User_Status]", "1"), conn.connection);
                SqlDataReader users = cmd.ExecuteReader();


                while (users.Read())
                {
                    int id = int.Parse(users[0].ToString());
                    string userFirstName = users[1].ToString();
                    string userLastName = users[2].ToString();
                    string userUsername = users[3].ToString();
                    string userPassword = users[4].ToString();
                    string userGender = users[5].ToString();
                    string userRole = users[6].ToString();
                    string userImage = users[7].ToString();
                    bool userStatus = bool.Parse(users[8].ToString());

                    User user = new User(id, userFirstName, userLastName, userUsername, userPassword, userGender, userRole, userImage, userStatus);
                    usersList.Add(user);
                }
                users.Close();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return usersList.Count > 0;
        }
    }
}
