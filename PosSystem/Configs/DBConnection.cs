using System.Data;
using System.Data.SqlClient;

namespace PosSystem.Configs
{
    public class DBConnection
    {
        private string connectionString = $"Server={Env.Server}; Database={Env.Database}; User Id={Env.Username}; Password={Env.Password}";
        private SqlConnection connection;

        /// <summary>
        /// Create SqlConnection
        /// </summary>
        private void createConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Execute SQL command to manipulate data in database.
        /// </summary>
        /// <param name="sqlCommand"></param>
        public DataTable ExecuteSqlCommand(string sqlCommand) 
        { 
            createConnection();
            DataTable dataTable = new DataTable();

            try
            {
                // connects database
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
                adapter.Fill(dataTable);

                // disconnects database
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            } 

            return dataTable;

        }

    }
}
