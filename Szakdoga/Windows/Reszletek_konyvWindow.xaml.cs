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

namespace Szakdoga.Windows
{
    /// <summary>
    /// Interaction logic for Reszletek_konyv.xaml
    /// </summary>
    public partial class Reszletek_konyv : Window
    {
        public Konyvek Model_konyvek { get; private set; }
        int? id = null;
        public Reszletek_konyv()
        {
            InitializeComponent();
            var besorolastarolo = Besorolas.List();
            besorolastarolo.Insert(0, new Besorolas());
            cbBesorolas.ItemsSource = besorolastarolo;
            cbBesorolas.DisplayMemberPath = "megnevezes";
            cbBesorolas.SelectedValuePath = "id";
           


        }
        public Reszletek_konyv(Konyvek konyvek) : this()
        {
            id = konyvek.id;
            txtCim.Text = konyvek.cim.ToString();
            txtSzerzo.Text = konyvek.szerzo.ToString();
            txtKiado.Text = konyvek.kiado_nev.ToString();
            txtAr.Text = konyvek.ar.ToString();
            cbBesorolas.SelectedValue = konyvek.besorolas_id;
            dtkiadasEv.SelectedDate = konyvek.kiadasev;

        }
        

        private bool kotelezoMezoEllenorzes()
        {
            
            if (txtCim.Text.Trim() == "")
                return false;
            if (txtSzerzo.Text.Trim() == "")
                return false;
            if (txtKiado.Text.Trim() == "")
                return false;
            if (txtAr.Text.Trim() == "")
                return false;
            if (cbBesorolas.SelectedValue == null)
                return false;
            if (dtkiadasEv == null)
                return false;

            return true;
        }
      

        private void btnMegsem_Click(object sender, RoutedEventArgs e)
        {

            this.DialogResult = false;
            

        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            if (kotelezoMezoEllenorzes())
            {
                Model_konyvek = new Konyvek();
                if (id != null)
                    Model_konyvek.id = (int)id;
                Model_konyvek.cim = txtCim.Text;
                Model_konyvek.szerzo = txtSzerzo.Text;
                Model_konyvek.kiado_nev = txtKiado.Text;
                Model_konyvek.ar= int.Parse(txtAr.Text);
                Model_konyvek.besorolas_id = (int)cbBesorolas.SelectedValue;
                Model_konyvek.Besorolasnev = cbBesorolas.Text;
                Model_konyvek.kiadasev = dtkiadasEv.SelectedDate;

                if (id != null)
                    Konyvek.Update(Model_konyvek);
                    
                    

                else
                    Model_konyvek.id = Konyvek.Insert(Model_konyvek);

                this.DialogResult = true;
                


            }

        }
    }
}
