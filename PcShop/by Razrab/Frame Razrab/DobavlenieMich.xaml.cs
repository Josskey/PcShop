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

namespace PcShop.by_Razrab.Frame_Razrab
{
    /// <summary>
    /// Логика взаимодействия для DobavlenieMich.xaml
    /// </summary>
    public partial class DobavlenieMich : Window
    {
        public DobavlenieMich()
        {
            InitializeComponent();
            Id_cat.ItemsSource = PcShopEntities.GetContext().Mouse.ToList();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Mouse mmouse = new Mouse()
            {

                NAME = Name.Text,
                PRICE = (int)Convert.ToDouble(price.Text),
                CHARACTERISTICS = characteristics.Text,
                URL = url.Text,
                ID_PRODUCT = (int)(PcShopEntities.GetContext().Mouse.First(x => x.NAME == c).ID_PRODUCT)
            };
            PcShopEntities.GetContext().Mouse.Add(mmouse);
            PcShopEntities.GetContext().SaveChanges();
            PcShop.by_Razrab.MenuRazrab sdel = new PcShop.by_Razrab.MenuRazrab();
            sdel.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.MenuRazrab sda = new PcShop.by_Razrab.MenuRazrab();
            sda.Show();
            this.Close();
        }
    }
}
