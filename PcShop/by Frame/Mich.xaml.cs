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

namespace PcShop.by_Frame
{
    /// <summary>
    /// Логика взаимодействия для Mich.xaml
    /// </summary>
    public partial class Mich : Page
    {
        public Mich()
        {
            InitializeComponent();
            DGridMich.ItemsSource = PcShopEntities.GetContext().Mouse.ToList();
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void BUY_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://pcshopic.tilda.ws/page2?tfc_storepartuid[307250475]=%D0%9C%D1%8B%D1%88%D1%8C"); //открытие ссылки в браузере
        }

    }
}
