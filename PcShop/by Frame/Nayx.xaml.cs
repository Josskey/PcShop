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
    /// Логика взаимодействия для Nayx.xaml
    /// </summary>
    public partial class Nayx : Page
    {
        public Nayx()
        {
            InitializeComponent();
            DGridNayx.ItemsSource = PcShopEntities.GetContext().Headset.ToList();
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BUY_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://pcshopic.tilda.ws/page2?tfc_storepartuid[307250475]=%D0%9A%D0%BE%D0%BC%D0%BF%D1%8C%D1%8E%D1%82%D0%B5%D1%80%D0%BD%D0%B0%D1%8F+%D0%B3%D0%B0%D1%80%D0%BD%D0%B8%D1%82%D1%83%D1%80%D0%B0"); //открытие ссылки в браузере
        }
    }
}
