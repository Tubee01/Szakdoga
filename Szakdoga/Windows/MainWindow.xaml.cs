using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;
using Szakdoga.Classes;
using Szakdoga.Pages;
using Szakdoga.Windows;

namespace Szakdoga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Konyvek> konyvlist = Konyvek.GetKonyvek();
        public static List<Vasarlok> vasarloklist = Vasarlok.GetVasarlok(null);


        private Kosar kosar;

        public Kosar Kosar
        {
            get
            {
                if (kosar == null)
                {
                    kosar = new Kosar();
                }
                return kosar;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

        }


        public static T IsWindowOpen<T>(string name = null)
        where T : Window
        {
            var windows = Application.Current.Windows.OfType<T>();
            return string.IsNullOrEmpty(name) ? windows.FirstOrDefault() : windows.FirstOrDefault(w => w.Name.Equals(name));
        }

        // Felső sor //   


        /// <summary>
        /// Könyvek
        /// </summary>

        private void Button_Books_Click(object sender, RoutedEventArgs e)
        {
            //Buttons

            Button_Books.IsEnabled = false;
            Button_Customers.IsEnabled = true;
            Button_Delete.IsEnabled = true;
            Button_Mod.IsEnabled = true;
            Button_Add_New.IsEnabled = true;

            // List visibility
            grdLista_konyv.Visibility = Visibility.Visible;
            grdLista_vasarlok.Visibility = Visibility.Hidden;
            grdLista_konyv.ItemsSource = konyvlist;

        }
        /// <summary>
        /// Könyvek
        /// </summary>

        private void Button_Customers_click(object sender, RoutedEventArgs e)
        {
            //Buttons

            Button_Books.IsEnabled = true;
            Button_Customers.IsEnabled = false;
            Button_Delete.IsEnabled = true;
            Button_Mod.IsEnabled = true;
            Button_Add_New.IsEnabled = true;

            //List visibility
            grdLista_vasarlok.Visibility = Visibility.Visible;
            grdLista_konyv.Visibility = Visibility.Hidden;
            //grdLista_szamlak.Visibility = Visibility.Hidden;

            // Lista 
            grdLista_vasarlok.ItemsSource = vasarloklist;

        }


        /// <summary>
        /// Kosár
        /// </summary>

        private void Button_Cart_Click(object sender, RoutedEventArgs e)
        {
            var window = IsWindowOpen<Window>("Kosar_window");

            if (window != null)
                window.Focus();

            else
            {
                Kosar.GetShow();
            }
            

        }


        /// <summary>
        /// Uj jelszó
        /// </summary>

        private void Button_New_PW_Click(object sender, RoutedEventArgs e)
        {
            var window = IsWindowOpen<Window>("Jelszomod_window");

            if (window != null)
            {
                window.Focus();
            }
            else
            {

                new JelszoMod().Show();
            }
        }

        /// <summary>
        /// Kijelentkezés
        /// </summary>

        private void Button_Logout_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new Login().Show();
        }


        /// <summary>
        /// Modositások
        /// </summary>

        private void btn_click_mod(object sender, RoutedEventArgs e)
        {
            if (grdLista_konyv.IsVisible == true)
            {
                var window = IsWindowOpen<Window>("Reszletek_konyv_window");

                if (window != null)
                {
                    window.Focus();
                }
                else
                {
                    if (grdLista_konyv.SelectedItem != null)
                    {
                        Konyvek s = (Konyvek)grdLista_konyv.SelectedItem;
                        var ablaks = new Reszletek_konyv(s);
                        if (ablaks.ShowDialog() == true)
                        {
                            int index = konyvlist.IndexOf(s);
                            konyvlist[index] = ablaks.Model_konyvek;
                            grdLista_konyv.Items.Refresh();
                        }

                        return;
                    }

                    MessageBox.Show("Nincs kiválasztott elem!", "Hiba");
                }
            }
            else if (grdLista_vasarlok.IsVisible == true)
            {
                var window = IsWindowOpen<Window>("Reszletek_vasarlok_window");

                if (window != null)
                {
                    window.Focus();
                }
                else
                {
                    if (grdLista_vasarlok.SelectedItem != null)
                    {
                        Vasarlok v = (Vasarlok)grdLista_vasarlok.SelectedItem;
                        var ablakv = new Reszletek_vasarlok(v);
                        if (ablakv.ShowDialog() == true)
                        {
                            int index = vasarloklist.IndexOf(v);
                            vasarloklist[index] = ablakv.Model_vasarlok;
                            grdLista_vasarlok.Items.Refresh();
                        }

                        return;
                    }

                    MessageBox.Show("Nincs kiválasztott elem!", "Hiba");


                }

            }
            else
            {

            }

        }



        /// <summary>
        /// Uj hozzáadás - könyv
        /// </summary>

        private void Button_Add_New_Click(object sender, RoutedEventArgs e)
        {
            if (grdLista_konyv.IsVisible == true)
            {
                var window = IsWindowOpen<Window>("Reszletek_konyvek_window");

                if (window != null)
                {
                    window.Focus();
                }
                else
                {

                    var ablak = new Reszletek_konyv();
                    if (ablak.ShowDialog() == true)
                    {

                        konyvlist.Add(ablak.Model_konyvek);
                        grdLista_konyv.Items.Refresh();
                    }

                }

            }
            else if (grdLista_vasarlok.IsVisible == true)
            {
                var window = IsWindowOpen<Window>("Reszletek_vasarlok_window");

                if (window != null)
                {
                    window.Focus();
                }
                else
                {

                    var ablak = new Reszletek_vasarlok();
                    if (ablak.ShowDialog() == true)
                    {

                        vasarloklist.Add(ablak.Model_vasarlok);
                        grdLista_vasarlok.Items.Refresh();
                    }

                }
            }
            else
            {

            }
        }

        /// <summary>
        /// Törlés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {


            if (grdLista_konyv.IsVisible == true)
            {
                if (grdLista_konyv.SelectedItem != null)
                {
                    MessageBoxResult result1 = MessageBox.Show("Tényleg törli a kijelölt elemet?", "Törlés", MessageBoxButton.YesNo);
                    if (result1 == MessageBoxResult.Yes)
                    {
                        Konyvek k = (Konyvek)grdLista_konyv.SelectedItem;
                        Konyvek.Delete(k);
                        konyvlist.Remove(k);
                        grdLista_konyv.Items.Refresh();

                    }
                    return;
                }
                MessageBox.Show("Nincs kiválaszott elem!", "Hiba");

            }
            else if (grdLista_vasarlok.IsVisible == true)
            {
                if (grdLista_vasarlok.SelectedItem != null)
                {
                    MessageBoxResult result1 = MessageBox.Show("Tényleg törli a kijelölt elemet?", "Törlés", MessageBoxButton.YesNo);
                    if (result1 == MessageBoxResult.Yes)
                    {
                        Vasarlok v = (Vasarlok)grdLista_vasarlok.SelectedItem;
                        Vasarlok.Delete(v);
                        vasarloklist.Remove(v);
                        grdLista_vasarlok.Items.Refresh();

                    }
                    return;
                }
                MessageBox.Show("Nincs kiválaszott elem!", "Hiba");
            }
            else
            {

            }
        }
        private void Button_kosarhozad_Click(object sender, RoutedEventArgs e)
        {

            var window = IsWindowOpen<Window>("Kosar_window");

            if (window != null)
            {
                window.Focus();
            }
            else
            {
                Kosar.AddItem(((Konyvek)grdLista_konyv.SelectedItem).id, 1);
                Kosar.GetCount(((Konyvek)grdLista_konyv.SelectedItem).ar);
                
            }

        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {   

            if(grdLista_konyv.IsVisible == true)
            {
                var klista = konyvlist.Where(x => x.cim.ToLower().Contains(TxtSearch.Text.ToLower()) || 
                                                         x.szerzo.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.kiadasev.ToString().Contains(TxtSearch.Text) ||
                                                         x.kiado_nev.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.Besorolasnev.ToLower().Contains(TxtSearch.Text.ToLower()) || 
                                                         x.ar.ToString().Contains(TxtSearch.Text)
                                                         ).ToList();
                grdLista_konyv.ItemsSource = klista;
                grdLista_konyv.Items.Refresh();
                return;
            }
            if (grdLista_vasarlok.IsVisible == true)
            {
                var vlista = vasarloklist.Where(x => x.cim.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.nev.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.id.ToString().Contains(TxtSearch.Text) ||
                                                         x.email.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.cim.ToLower().Contains(TxtSearch.Text.ToLower()) ||
                                                         x.telefon.ToString().Contains(TxtSearch.Text)
                                                         ).ToList();
                grdLista_vasarlok.ItemsSource = vlista;
                grdLista_vasarlok.Items.Refresh();
                return;
            }




        }
    }
}

