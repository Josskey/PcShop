using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PcShop
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


        private void info(object sender, RoutedEventArgs e)
        {

         MessageBox.Show("Интернет магазин компьютерной техники и перефирии. Мы предлагаем широчайший ассортимент товаров, сервисов и услуг.Покупателям представлен огромный выбор наименований компьютерной, аудио/ видео, цифровой и климатической техники, медиа товаров, и других аксессуаров."); 

        }

        private void accaunt(object sender, RoutedEventArgs e)
        {

        }

        private void sait(object sender, RoutedEventArgs e)
        {
            Process.Start("http://pcshopic.tilda.ws"); //открытие ссылки в браузере
        }

        private void vikl(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // закрытие окна
        }

        private void catalog(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PcShop.Menu Menu = new PcShop.Menu();
            Menu.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            PcShop.by_Razrab.MenuRazrab qwert = new PcShop.by_Razrab.MenuRazrab();
            qwert.Show();
        }
    }
    }

