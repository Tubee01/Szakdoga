using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Szakdoga
{
    public static class DatabaseConnection
    {

        private static MySqlConnection _databaseConnection = null;

        public static MySqlConnection DatabaseCon {
            get {
                if (_databaseConnection == null) {
                    _databaseConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Mysql"].ConnectionString);
                    }
                return _databaseConnection;

            }
        }
   
       
    }
}
