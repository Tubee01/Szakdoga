using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdoga.Classes
{
    public class Konyvek
    {

        public int id { get; set; }
        public string cim { get; set; }
        public int besorolas_id { get; set; }
        public string Besorolasnev { get; set; }
        public string szerzo { get; set; }
        public string kiado_nev { get; set; }
        public int ar { get; set; }
        public DateTime? kiadasev { get; set; }
        public string search { get; set; }

        public Konyvek()
        {
        }


        public Konyvek(MySqlDataReader reader)
        {
            id = Convert.ToInt32(reader["id"]);
            cim = reader["cim"].ToString();
            szerzo = reader["szerzo"].ToString();
            kiado_nev = reader["kiado_nev"].ToString();
            ar = Convert.ToInt32(reader["ar"]);
            besorolas_id = Convert.ToInt32(reader["besorolas_id"]);
            kiadasev = reader["kiadasev"] == DBNull.Value ? null
                       : (DateTime?)Convert.ToDateTime(reader["kiadasev"]);
            Besorolasnev = reader["besorolasnev"].ToString();

        }
        public static List<Konyvek> GetKonyvek()
        {
            List<Konyvek> list = new List<Konyvek>();
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                string sql = " SELECT" +
                             " k.id," +
                             " k.besorolas_id," +
                             " k.cim," +
                             " k.szerzo," +
                             " k.kiadasev," +
                             " k.ar," +
                             " k.kiado_nev," +
                             " b.id," +
                             " b.megnevezes as besorolasnev" +
                             " FROM konyvek AS k" +
                             " JOIN besorolas AS b" +
                             "   ON k.besorolas_id = b.id";
                

        
                using (var cmd = new MySqlCommand(sql, con))
                {
                    

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(new Konyvek(reader));
                    }
                }
            }
            return list;

        }
        public static int Insert(Konyvek model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = "INSERT INTO konyvek( cim , szerzo , kiadasev , besorolas_id , ar , kiado_nev) " +
                          "values ( @cim, @szerzo, @kiadasev, @besorolas_id, @ar , @kiado_nev)";
                using (var cmd = new MySqlCommand(sql, con))
                {


                    cmd.Parameters.AddWithValue("@cim", model.cim);
                    cmd.Parameters.AddWithValue("@kiadasev", model.kiadasev);
                    cmd.Parameters.AddWithValue("@besorolas_id", model.besorolas_id);
                    cmd.Parameters.AddWithValue("@ar", model.ar);
                    cmd.Parameters.AddWithValue("@kiado_nev", model.kiado_nev);
                    cmd.Parameters.AddWithValue("@szerzo", model.szerzo);

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public static void Update(Konyvek model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = "update konyvek set " +
                                " id = @id, " +
                                " cim = @cim, szerzo = @szerzo, kiadasev = @kiadasev, " +
                                " besorolas_id = @besorolas_id, ar = @ar , kiado_nev = @kiado_nev "
                                +
                          " where id = @id";
                using (var cmd = new MySqlCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@id", model.id);
                    cmd.Parameters.AddWithValue("@cim", model.cim);
                    cmd.Parameters.AddWithValue("@szerzo", model.szerzo);
                    cmd.Parameters.AddWithValue("@kiadasev", model.kiadasev);
                    cmd.Parameters.AddWithValue("@besorolas_id", model.besorolas_id);
                    cmd.Parameters.AddWithValue("@ar", model.ar);
                    cmd.Parameters.AddWithValue("@kiado_nev", model.kiado_nev);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(Konyvek model)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = "delete from konyvek " +
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