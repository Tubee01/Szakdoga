using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using MySql.Data.MySqlClient;

namespace Szakdoga.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       
        public Login()
        {
            InitializeComponent();
            
            
        }
        private bool OpenConnection()
        {
            try
            {
                if (DatabaseConnection.DatabaseCon.State == ConnectionState.Open) return true;

                DatabaseConnection.DatabaseCon.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show(" >>>> Cannot contact MySQL Server ", "Error");//MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show(" >>>> Invalid username/password, please try again", "Error");
                        break;

                    case 1042:
                        MessageBox.Show(" >>>> Unable to resolve DNS", "Error");
                        break;
                    case 1044:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }


        private void B_Login_Click(object sender, RoutedEventArgs e)
        {
                     
            
            if (OpenConnection()) //ha van connection
            {
                if (TB_Username == null && PB_Password == null)
                {
                    MessageBox.Show("Invalid username or password");
                    return; 
                }

                MySqlDataAdapter check = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + TB_Username.Text + "' AND password='" + PB_Password.Password + "'", DatabaseConnection.DatabaseCon);
                DataTable dtcheck = new DataTable();
                check.Fill(dtcheck);
                if (dtcheck.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    new MainWindow().Show();

                    //
                    string log_logins = "INSERT INTO log_logins(username, datum) values('" + TB_Username.Text + "', '" + DateTime.UtcNow + "');";
                    MySqlCommand logCommand = new MySqlCommand(log_logins, DatabaseConnection.DatabaseCon);
                    MySqlDataReader Myreader2;
                    Myreader2 = logCommand.ExecuteReader();
                    DatabaseConnection.DatabaseCon.Close();

                    //
                    string update = "UPDATE login SET lastlogin_id=(SELECT id FROM log_logins ORDER BY id DESC LIMIT 1 )WHERE username='" + TB_Username.Text + "';";
                    OpenConnection();
                    MySqlCommand logCommand2 = new MySqlCommand(update, DatabaseConnection.DatabaseCon);
                    MySqlDataReader Myreader3;
                    Myreader3 = logCommand2.ExecuteReader();
                    DatabaseConnection.DatabaseCon.Close();
                    return;
                }

                MessageBox.Show("Invalid username or password","Error");
                PB_Password.Clear();
                return;



            }         
           
        }
    }
}
