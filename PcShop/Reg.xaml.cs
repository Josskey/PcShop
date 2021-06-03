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
using System.Windows.Shapes;

namespace PcShop
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/public204152182"); //открытие ссылки в браузере
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void reg(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PcShop.MainWindow glava = new PcShop.MainWindow();
            glava.Show();
        }

        private void vhod(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PcShop.MainWindow glav = new PcShop.MainWindow();
            glav.Show();
        }
    }
}
