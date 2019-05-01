using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Szakdoga.Classes;

namespace Szakdoga
{
    /// <summary>
    /// Interaction logic for Kosar.xaml
    /// </summary>
    public partial class KosarWindow : Window
    {
        public Kosar kosar;

        public bool IDbekerve;
        public KosarWindow(Kosar kosar)
        {

            InitializeComponent();
            this.kosar = kosar;
            grdlista_kosar.ItemsSource = kosar.GetKosarItems();
            TB_osszeg.DataContext = kosar.osszeg;
            IDbekerve = false;


        }



        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Keres(object sender, RoutedEventArgs e)
        {
            int s;
            if (int.TryParse(TxtVasarloID.Text, out s))
            {
                var list = Vasarlok.GetVasarlok(s);
                if (list.Count > 0)
                {
                    DataContext = list;
                    IDbekerve = true;

                    return;
                }
            }
            MessageBox.Show("Rossz ID", "Hiba");
        }

        private void Button_Click_Kiad(object sender, RoutedEventArgs e)
        {   if ( IDbekerve !=false && grdlista_kosar.HasItems == true)
            {
                string tetelek = "";
                grdlista_kosar.SelectAll();
                foreach (var item in grdlista_kosar.ItemsSource)
                {
                    int _quantity = (((Kosar.KosarItem)grdlista_kosar.SelectedItem).quantity);
                    string _cim = (((Kosar.KosarItem)grdlista_kosar.SelectedItem).konyv.cim);
                    kosar.RemoveItem(((Kosar.KosarItem)grdlista_kosar.SelectedItem).konyv.id, ((Kosar.KosarItem)grdlista_kosar.SelectedItem).konyv.ar);
                    grdlista_kosar.ItemsSource = kosar.GetKosarItems();
                    tetelek +=""+ _quantity + " x " + _cim + " ";
                    


                }
                Kosar.InsertToDB(Convert.ToInt32(TxtVasarloID.Text), Convert.ToInt32(TB_osszeg.Text), tetelek);
                kosar.osszeg = 0;
                TB_osszeg.DataContext = kosar.osszeg;
                IDbekerve = false;
                return;
            }
            if (IDbekerve == false)
            {
                MessageBox.Show("Kérje be a vásárló adatait!", "Hiba");
            }else
            {
                MessageBox.Show("Üres a kosár!","Hiba");
            }

            }

        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {

            if (grdlista_kosar.SelectedItem != null)
            {
                MessageBoxResult result1 = MessageBox.Show("Tényleg törli a kijelölt elemet?", "Törlés", MessageBoxButton.YesNo);
                if (result1 == MessageBoxResult.Yes)
                {
                    
                    kosar.RemoveItem(((Kosar.KosarItem)grdlista_kosar.SelectedItem).konyv.id, ((Kosar.KosarItem)grdlista_kosar.SelectedItem).konyv.ar);
                    TB_osszeg.DataContext = kosar.osszeg;
                    grdlista_kosar.ItemsSource = kosar.GetKosarItems();
                    grdlista_kosar.Items.Refresh();

                }
                return;
            }
            MessageBox.Show("Nincs kiválaszott elem!", "Hiba");


        }

    }
}
