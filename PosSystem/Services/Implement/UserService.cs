using System.Data;
using PosSystem.Repositories;
using PosSystem.Configs;
using PosSystem.Utils;
using PosSystem.Models;
using System.Data.SqlClient;
namespace PosSystem.Services.Implement
{
    public class UserService : IUserRepository
    {
        private DBConnection conn = DBConnection.GetInstance();
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

        /// <summary>
        /// Filter Data
        /// </summary>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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

        public void Save(User user)
        {
            conn.connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.SaveUser("tblUsers", user._FirstName, user._LastName, user._Username, user._Password, user._Gender, user._Role, user._Image), conn.connection);
                cmd.ExecuteNonQuery();
                FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                formMessageBoxInfo.SetInfo("គណនេយ្យថ្មីត្រូវបា​នបញ្ចូល ដោ​យជោ​គជ័យ", "success");
                formMessageBoxInfo.ShowDialog();
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

        }

        public List<User> FindUsername(string username)
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand cmd = new SqlCommand(GenerateCommand.GetAllWhereTwoColumn("[tblUsers]", "[User_Username]", username, "[User_Status]", "1"), conn.connection);
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
                SqlCommand cmd = new SqlCommand(GenerateCommand.GetAllWhereThreeColumn("[tblUsers]", "[User_Username]", username, "[User_Password]", Security.EncodePasswordToBase64(password), "[User_Status]", "1"), conn.connection);
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

        public void UpdateUser(User user, string username)
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand _cmd = new SqlCommand(GenerateCommand.GetAllWhereOneColumn("[tblUsers]", "[User_Username]", username), conn.connection);
                SqlDataReader users = _cmd.ExecuteReader();


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

                    User _user = new User(id, userFirstName, userLastName, userUsername, userPassword, userGender, userRole, userImage, userStatus);
                    usersList.Add(_user);
                }
                users.Close();

                if (usersList.Count > 0)
                {
                    _cmd = new SqlCommand(GenerateCommand.updateUser("[tblUsers]", user._FirstName, user._LastName, username, user._Password, user._Gender, user._Role, user._Image), conn.connection);
                    _cmd.ExecuteNonQuery();

                    FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                    formMessageBoxInfo.SetInfo("គណនេយ្យត្រូវបា​នធ្វើបច្ចុប្យបន្ធភាពដោ​យជោ​គជ័យ", "success");
                    formMessageBoxInfo.ShowDialog();
                }

                else
                {

                    FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                    formMessageBoxInfo.SetInfo("ចូរបំពេញឈ្មោះគណនេយ្យឲ្យបានត្រឹមត្រូវ!", "warnning");
                    formMessageBoxInfo.ShowDialog();
                }
                
                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void DeleteUser(string username)
        {
            conn.connection.Open();
            List<User> usersList = new List<User>();

            try
            {
                SqlCommand _cmd = new SqlCommand(GenerateCommand.GetAllWhereOneColumn("[tblUsers]", "[User_Username]", username), conn.connection);
                SqlDataReader users = _cmd.ExecuteReader();


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

                    User _user = new User(id, userFirstName, userLastName, userUsername, userPassword, userGender, userRole, userImage, userStatus);
                    usersList.Add(_user);
                }
                users.Close();

                if (usersList.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand(GenerateCommand.deleteWhereOneColumn("tblUsers", "User_Username", username), conn.connection);
                    cmd.ExecuteNonQuery();

                    FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                    formMessageBoxInfo.SetInfo("គណនេយ្យនេះត្រូវបាន ដោយជោ​គជ័យ", "success");
                    formMessageBoxInfo.ShowDialog();
                }

                else
                {

                    FormMessageBoxInfo formMessageBoxInfo = new FormMessageBoxInfo();
                    formMessageBoxInfo.SetInfo("ចូរបំពេញឈ្មោះគណនេយ្យឲ្យបានត្រឹមត្រូវ!", "warnning");
                    formMessageBoxInfo.ShowDialog();
                }

                conn.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
    }
}
