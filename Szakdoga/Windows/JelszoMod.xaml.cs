using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
using Szakdoga.Pages;
using Szakdoga.Windows;
namespace Szakdoga.Windows
{
    /// <summary>
    /// Interaction logic for JelszoMod.xaml
    /// </summary>
    public partial class JelszoMod : Window
    {
        public JelszoMod()
        {
            InitializeComponent();
            
        }
            
            
            private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            string currentpwQuery = "SELECT password FROM login WHERE lastlogin_id=(SELECT id FROM log_logins ORDER BY id DESC LIMIT 1 );";
            DatabaseConnection.DatabaseCon.Open();
            
            MySqlCommand cmdPW = new MySqlCommand(currentpwQuery, DatabaseConnection.DatabaseCon);
            MySqlDataReader myPWReader = cmdPW.ExecuteReader();
            myPWReader.Read();
            object currentpw = myPWReader.GetString(0);
            string _currentpw = Convert.ToString(currentpw);
            DatabaseConnection.DatabaseCon.Close();


            if (TB_newpw.Password == TB_repw.Password && TB_currentpw.Password == _currentpw && _currentpw !=TB_newpw.Password)
            {
                string query = "SELECT username FROM log_logins ORDER BY id DESC LIMIT 1";
                DatabaseConnection.DatabaseCon.Open();
                MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.DatabaseCon);
                MySqlDataReader myUserReader = cmd.ExecuteReader();
                myUserReader.Read();
                object username = myUserReader.GetString(0);
                DatabaseConnection.DatabaseCon.Close();

                //

                string mSQLUpdate = "UPDATE login SET password = '" + TB_repw.Password + "' WHERE username = '" + username + "'";
                MySqlCommand logCommand = new MySqlCommand(mSQLUpdate, DatabaseConnection.DatabaseCon);
                MySqlDataReader MyReader2;
                DatabaseConnection.DatabaseCon.Open();
                MyReader2 = logCommand.ExecuteReader();
                DatabaseConnection.DatabaseCon.Close();
                MessageBox.Show("Password Changed Successfully");
                
                this.Close();
                
            }
            else
            {

                if( _currentpw == TB_repw.Password)
                {
                    MessageBox.Show("New and Current Passwords can not match");
                    TB_currentpw.Clear();
                    TB_newpw.Clear();
                    TB_repw.Clear();

                }
                else
                {
                    MessageBox.Show("Passwords does not match");
                    TB_currentpw.Clear();
                    TB_newpw.Clear();
                    TB_repw.Clear();

                }

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }

