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

namespace PcShop
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    Frame1.Navigate(new PcShop.by_Frame.Comp()); // открытие страницы
                    break;
                case 1:
                    Frame1.Navigate(new PcShop.by_Frame.Nayx()); // открытие страницы
                    break;
                case 2:
                    Frame1.Navigate(new PcShop.by_Frame.Klava()); // открытие страницы
                    break;
                case 3:
                    Frame1.Navigate(new PcShop.by_Frame.Mich()); // открытие страницы
                    break;
                
            }
        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

     
        private void back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PcShop.MainWindow glavka = new PcShop.MainWindow();
            glavka.Show();
        }

        private void search(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}