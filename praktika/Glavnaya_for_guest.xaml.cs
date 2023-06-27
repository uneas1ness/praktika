using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace praktika
{
    /// <summary>
    /// Логика взаимодействия для Glavnaya_for_guest.xaml
    /// </summary>
    public partial class Glavnaya_for_guest : Window
    {

        MyDBcontext db = new MyDBcontext();

        public Glavnaya_for_guest()
        {
            InitializeComponent();

            Loaded += Glavnaya_for_guest_Loaded;
        }
        private void Glavnaya_for_guest_Loaded(object sender, RoutedEventArgs e)
        {
            // гарантируем, что база данных создана
            db.Database.EnsureCreated();
            // загружаем данные из БД
            db.Products.Load();
            // и устанавливаем данные в качестве контекста
            DataContext = db.Products.Local.ToObservableCollection();
        }
       



    }
}
