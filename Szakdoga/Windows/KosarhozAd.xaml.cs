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

namespace Szakdoga.Windows
{
    /// <summary>
    /// Interaction logic for KosarhozAd.xaml
    /// </summary>
    public partial class KosarhozAd : Window
    {
        public KosarhozAd()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
