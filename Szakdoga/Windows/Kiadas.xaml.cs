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
    /// Interaction logic for Kiadas.xaml
    /// </summary>
    public partial class Kiadas : Window
    {
        public Konyvek Model_konyvek { get; private set; }
        public Konyvek Model { get; set; }

        public Kiadas()
        {
            InitializeComponent();
            grdlista_kosar.Items.Add(Model);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
                    return;
                }
            }                 
            MessageBox.Show("Rossz ID", "Hiba");
        }
    }
}
