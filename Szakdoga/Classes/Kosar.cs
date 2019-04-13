using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Szakdoga.Classes
{
    
    public class Kosar
    {

        public int osszeg { get; set; }


        public struct KosarItem
        {
            public Konyvek konyv { get; set; }
            public int quantity { get; set; }
           

            public KosarItem(Konyvek konyv, int quantity)
            {
                this.konyv = konyv;
                this.quantity = quantity;
                
               
            }
        }

        private Dictionary<int,int> kosarItems = new Dictionary<int, int>();
        private KosarWindow kWindow;
        private int _quantity;

        public void AddItem(int id, int quantity = 1)
        {
            if (kosarItems.ContainsKey(id))
            {
                kosarItems[id] += quantity;
                return;
            }
            kosarItems.Add(id, quantity);
           
            
        }
        public void GetCount(int ar)
        {
            this.osszeg += MainWindow.konyvlist.Find(x => x.ar == ar).ar;

        }

        public void RemoveItem(int id, int ar)
        {
            kosarItems.TryGetValue(id, out _quantity);
            osszeg = osszeg - (_quantity * ar);
            kosarItems.Remove(id);
            
            
           

        }
        

        public List<KosarItem> GetKosarItems()
        {
            List<KosarItem> selectedItems = new List<KosarItem>(kosarItems.Count);
            
            
            foreach(var item in kosarItems )
            {
                selectedItems.Add(new KosarItem(MainWindow.konyvlist.Find(x => x.id == item.Key),item.Value));
            }
            return selectedItems;
            


        }
      

        public void GetShow()
        {

            kWindow = new KosarWindow(this);
            kWindow.Show();
        }
        

        public static int InsertToDB(int vasarloId, int ar, string tetelek)
        {
            using (var con = new MySqlConnection(DatabaseConnection.DatabaseCon.ConnectionString))
            {
                con.Open();
                var sql = " INSERT INTO kiadott( vasarloId, datum, ar, tetelek) " +
                          "values ( @vasarloId, @datum, @ar, @tetelek)";
                using (var cmd = new MySqlCommand(sql, con))
                {


                    cmd.Parameters.AddWithValue("@vasarloId", vasarloId);
                    cmd.Parameters.AddWithValue("@datum", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.Parameters.AddWithValue("@tetelek", tetelek);


                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }
    }
}
