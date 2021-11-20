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
            return $"SELECT * FROM {tableName} WHERE {columnName} = '{value}';";
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
            return $"SELECT * FROM {tableName} WHERE {columnName1} = '{value1}' AND {columnName2} = '{value2}';";
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
    }
}
