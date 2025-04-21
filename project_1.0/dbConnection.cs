using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project_1._0
{
    public class dbConnection
    {
        private static string connStr = "server=localhost;user=root;database=WorkZen;port=3306;password=Mehtab2046;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
