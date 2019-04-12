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
    /// Interaction logic for Reszletek_vasarlok.xaml
    /// </summary>
    public partial class Reszletek_vasarlok : Window
    {
        public Vasarlok Model_vasarlok { get; private set; }
        int? id = null;

        public Reszletek_vasarlok()
        {
            InitializeComponent();
       
        }

        public Reszletek_vasarlok(Vasarlok vasarlok) : this()
        {
            id = vasarlok.id;
            txtNev.Text = vasarlok.nev.ToString();
            txtCim.Text = vasarlok.cim.ToString();
            txtEmail.Text = vasarlok.email.ToString();
            txtTelsz.Text = vasarlok.telefon.ToString();
        }


        private bool kotelezoMezoEllenorzes()
        {

            if (txtCim.Text.Trim() == "")
                return false;
            if (txtNev.Text.Trim() == "")
                return false;
            if (txtEmail.Text.Trim() == "")
                return false;
            if (txtTelsz.Text.Trim() == "")
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
                Model_vasarlok = new Vasarlok();
                if (id != null)
                    Model_vasarlok.id = (int)id;
                Model_vasarlok.nev = txtNev.Text;
                Model_vasarlok.cim = txtCim.Text;
                Model_vasarlok.email = txtEmail.Text;
                Model_vasarlok.telefon = txtTelsz.Text; 

                if (id != null)
                    Vasarlok.Update(Model_vasarlok);



                else
                    Model_vasarlok.id = Vasarlok.Insert(Model_vasarlok);

                this.DialogResult = true;



            }

        }
    }
}