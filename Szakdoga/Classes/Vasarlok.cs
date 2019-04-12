using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdoga.Classes
{
    public class Vasarlok 
    {
        

        public int id { get; set; }
        public string nev { get; set; }
        public string cim { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }



        public Vasarlok()
        {
            
        }

        public Vasarlok(MySqlDataReader reader)
        {
            
            id = Convert.ToInt32(reader["id"]);
            nev = reader["nev"].ToString();
            cim = reader["cim"].ToString();
            email = reader["email"].ToString();
            telefon = reader["telefon"].ToString();
            

        }
        public static List<Vasarlok> GetVasarlok(int? vasarloId)
        {
            List<Vasarlok> lista = new List<Vasarlok>();

            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                string sql = " SELECT " +
                           "  id,   " +
                           "  nev,  " +
                           "  cim,  " +
                           "  email, " +
                           "  telefon " +
                           "  FROM konyvesbolt.vasarlok ";
                if (vasarloId != null)
                    sql += " WHERE id = @vasarloId";

                using (var cmd = new MySqlCommand(sql, con))
                {
                   
                    cmd.Parameters.AddWithValue("@vasarloId", vasarloId );

                    using (var reader = cmd.ExecuteReader())
                    {   
                        while (reader.Read())
                           
                            lista.Add(new Vasarlok(reader));
                    }
                }
               

            }
            return lista;
                 
          
                    
        }


     


        public static int Insert(Vasarlok model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = " INSERT INTO vasarlok( nev, cim, email, telefon) " +
                          "values ( @nev, @cim, @email, @telefon)";
                using (var cmd = new MySqlCommand(sql, con))
                {


                    cmd.Parameters.AddWithValue("@nev", model.nev);
                    cmd.Parameters.AddWithValue("@cim", model.cim);
                    cmd.Parameters.AddWithValue("@email", model.email);
                    cmd.Parameters.AddWithValue("@telefon", model.telefon);
                  

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public static void Update(Vasarlok model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = "update vasarlok set " +
                                " id = @id, " +
                                " nev = @nev, cim = @cim, email = @email, " +
                                " telefon = @telefon"
                                +
                          " where id = @id";
                using (var cmd = new MySqlCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@id", model.id);
                    cmd.Parameters.AddWithValue("@nev", model.nev);
                    cmd.Parameters.AddWithValue("@cim", model.cim);
                    cmd.Parameters.AddWithValue("@email", model.email);
                    cmd.Parameters.AddWithValue("@telefon", model.telefon);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(Vasarlok model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = "delete from vasarlok " +
                          " where id = @id";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", model.id);
                    cmd.ExecuteNonQuery();
                }
            }

        }

    }
}