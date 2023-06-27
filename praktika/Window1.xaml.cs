using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new AplicattionsContext())
            {
                var person = new Persons 
                {
                    FirstName = fullNameTextBox.Text,
                    gender = genderComboBox.Text,
                    password = passwordBox.Password,
                    username = usernameTextBox.Text,

                };

                db.person.Add(person);
                db.SaveChanges();
            }

            MessageBox.Show("Регистрация прошла успешно!");

        }

        
    }
}
    

