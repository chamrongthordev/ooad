using System.Data;
using System.Data.SqlClient;

namespace PosSystem.Configs
{
    public class DBConnection
    {
        private string connectionString = $"Server={Env.Server}; Database={Env.Database}; User Id={Env.Username}; Password={Env.Password}";
        public SqlConnection connection;
        public static DBConnection? dBConnection;

        private DBConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Get Singleton of DBConnection
        /// </summary>
        /// <returns></returns>
        public static DBConnection GetInstance() 
        { 
            
            if(dBConnection == null)
            {
                dBConnection = new DBConnection();
            }

            return dBConnection;
        }

    }
}
