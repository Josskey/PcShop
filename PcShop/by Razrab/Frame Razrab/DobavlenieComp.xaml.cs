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
    /// Логика взаимодействия для DobavlenieComp.xaml
    /// </summary>
    public partial class DobavlenieComp : Window
    {
        public DobavlenieComp()
        {
            InitializeComponent();
            Id_cat.ItemsSource = PcShopEntities.GetContext().Сomputer.ToList();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Сomputer Ccuputer = new Сomputer()
            {

                NAME = Name.Text,
                PRICE = (int)Convert.ToDouble(price.Text),
                CHARACTERISTICS = characteristics.Text,
                URL = url.Text,
                ID_PRODUCT = (int)(PcShopEntities.GetContext().Сomputer.First(x => x.NAME == c).ID_PRODUCT) 
            };
            PcShopEntities.GetContext().Сomputer.Add(Ccuputer);
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

