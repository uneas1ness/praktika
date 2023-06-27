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

namespace praktika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_reg(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            
        }

        private void btn_Vxod(object sender, RoutedEventArgs e)
        {

            string username = text1.Text;
            string password = text2.Text;

            if (username == "Admin" && password == "1111")
            {
                // Пользователь с правильным логином и паролем
                // перенаправляется на другую форму.
                for_boss for_Boss = new for_boss();
                for_Boss.Show();
                this.Hide();
            }
            else
            {
                // Выводится сообщение об ошибке.
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        private void Btn_Guest(object sender, RoutedEventArgs e)
        {
            Glavnaya_for_guest w2 = new Glavnaya_for_guest();
            w2.Show();
            this.Hide();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
