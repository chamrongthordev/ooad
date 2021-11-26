using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Utils
{
    public class GenerateCommand
    {
        /// <summary>
        /// Get all data from a table by checking conditions with one column and its value pair.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <param name="value"></param>
        /// <returns>Sql Command</returns>
        public static string GetAllWhereOneColumn(string tableName, string columnName, string value )
        {
            return $"SELECT * FROM {tableName} WHERE {columnName} = N'{value}';";
        }

        /// <summary>
        /// Get all data from a table by checking conditions with two columns and its value pair.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName1"></param>
        /// <param name="value1"></param>
        /// <param name="columnName2"></param>
        /// <param name="value2"></param>
        /// <returns>Sql Command</returns>
        public static string GetAllWhereTwoColumn(string tableName, string columnName1, string value1, string columnName2, string value2 )
        {
            return $"SELECT * FROM {tableName} WHERE {columnName1} = N'{value1}' AND {columnName2} = N'{value2}';";
        }

        public static string FilterByTwoColumn(string tableName, string columnName1, string value1, string columnName2, string value2)
        {
            return $"SELECT * FROM {tableName} WHERE {columnName1} LIKE N'{value1}%' AND {columnName2} = N'{value2}';";
        }

        public static string FilterByOneColumn(string tableName, string columnName, string value)
        {
            return $"SELECT * FROM {tableName} WHERE {columnName} LIKE N'{value}%';";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName1"></param>
        /// <param name="value1"></param>
        /// <param name="columnName2"></param>
        /// <param name="value2"></param>
        /// <param name="columnName3"></param>
        /// <param name="value3"></param>
        /// <returns></returns>
        public static string GetAllWhereThreeColumn(string tableName, string columnName1, string value1, string columnName2, string value2, string columnName3, string value3)
        {
            return $"SELECT * FROM {tableName} WHERE {columnName1} = N'{value1}' AND {columnName2} = N'{value2}' AND {columnName3} = N'{value3}';";
        }

        /// <summary>
        /// Get all data from a table
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns>Sql Command</returns>
        public static string GetAll(string tableName)
        {
            return $"SELECT * FROM {tableName};";
        }

        public static string SaveUser(string tableName, string firstName, string lastName, string username, string password, string gender, string role, string image)
        {
            return $"INSERT INTO {tableName} (User_FirstName, User_LastName, User_Username, User_Password, User_Gender, User_Role, User_Image, User_Status) VALUES (N'{firstName}', N'{lastName}', N'{username}', N'{password}', N'{gender}', N'{role}', N'{image}', '1')";
        }

        public static string updateUser(string tableName, string firstName, string lastName, string username, string password, string gender, string role, string image)
        {
            if (password == "")
            {
                return $"UPDATE {tableName} SET User_FirstName = N'{firstName}', User_LastName = N'{lastName}', User_Gender = N'{gender}', User_Role = N'{role}', User_Image = '{image}' WHERE User_Username = '{username}'";
            }
            return $"UPDATE {tableName} SET User_FirstName = N'{firstName}', User_LastName = N'{lastName}', User_Password = '{password}', User_Gender = N'{gender}', User_Role = N'{role}', User_Image = '{image}' WHERE User_Username = '{username}'";
        }

        public static string deleteWhereOneColumn(string tableName, string column, string value)
        {
            return $"UPDATE {tableName} SET User_Status = '0' WHERE {column} = '{value}'";
        }
    }
}
