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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<City> cities = new List<City>();
            using (var context = new DataContext())
            {
                cities = context.Cities.ToList();

            }
            foreach (City i in cities)
            {
                listCities.Items.Add(i.Name);
            }
            //phone = userPhone.ToString();
            //comment = userComment.ToString();
            //addButton.Click += Button_Click();
            //if (string.IsNullOrWhiteSpace(phone) == false && int.TryParse(phone, out intPhone) == true)//Tryparse не работает а без него не те значения ВЫЯСНИТЬ ПОЧЕМУ
            //{
            //    addButton.Click += Button_Click();
            //    //    delegate
            //    //{
            //    //    using (var context = new DataContext())
            //    //    {
            //    //        context.userPhones.Add(new UserPhone(phone, comment));
            //    //        context.SaveChanges();
            //    //    }
            //    //};
            //}

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phone, comment;
            phone = userPhone.Text.ToString();
            comment = userComment.Text.ToString();
            UserPhone _userPhone = new UserPhone(phone, comment);
            if (string.IsNullOrWhiteSpace(phone) == false)
            {
                using (var context = new DataContext())
                {
                    context.userPhones.Add(_userPhone);
                    context.SaveChanges();
                }
            }
        }
    }
}
