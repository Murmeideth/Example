using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Example
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "example";
            string user = "root";
            string password = "root";

            return DBMySqlUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
