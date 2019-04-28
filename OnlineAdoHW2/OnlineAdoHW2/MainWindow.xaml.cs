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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnlineAdoHW2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string _connectionstring;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string _login, _password;
            _login = userLogin.Text.ToString();
            _password = userPassword.Text.ToString();
            DBservice dbService = new DBservice();
            if (string.IsNullOrWhiteSpace(_login) == false&& string.IsNullOrWhiteSpace(_password) == false)
            {
                dbService.stringBuilder.UserID = _login;
                dbService.stringBuilder.Password = _password;
                _connectionstring = dbService.stringBuilder.ConnectionString;
                dbService.AddTable(_connectionstring);
            }
        }
    }
}
