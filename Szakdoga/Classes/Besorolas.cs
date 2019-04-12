using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdoga.Classes
{
    class Besorolas
    {
        public int? id { get; set; }
        public string megnevezes { get; set; }

        public Besorolas()
        { }

        public Besorolas(MySqlDataReader reader)
        {
            id = Convert.ToInt32(reader["id"]);
            megnevezes = reader["megnevezes"].ToString();
        }

        public static List<Besorolas> List()
        {
            List<Besorolas> lista = new List<Besorolas>();
        
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                string sql = " SELECT id, megnevezes" +
                             " FROM besorolas";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            lista.Add(new Besorolas(reader));
                    }
                }
            }
            return lista;
        }
    }
}
