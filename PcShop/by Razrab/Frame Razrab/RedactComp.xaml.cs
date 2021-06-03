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
    /// Логика взаимодействия для RedactComp.xaml
    /// </summary>
    public partial class RedactComp : Window
    {
        int id;
        public RedactComp(int Mid)
        {
            id = Mid; 
            InitializeComponent();
            Id_cat.ItemsSource = PcShopEntities.GetContext().Сomputer.ToList();
            Сomputer ldsa = (from m in PcShopEntities.GetContext().Сomputer
                             where m.ID_PRODUCT == Mid
                             select m).Single(); 
            Name.Text = ldsa.NAME;
            price.Text = ldsa.PRICE.ToString();
            characteristics.Text = ldsa.CHARACTERISTICS.ToString();
            url.Text = ldsa.URL.ToString();
            Id_cat.SelectedItem = ldsa.ID_PRODUCT;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Сomputer ldsa = (from m in PcShopEntities.GetContext().Сomputer
                             where m.ID_PRODUCT == id
                             select m).Single();
            ldsa.NAME = Name.Text;
            ldsa.PRICE = (int)Convert.ToDouble(price.Text);
            ldsa.CHARACTERISTICS = (characteristics.Text);
            ldsa.URL = (url.Text);
            ldsa.ID_PRODUCT = (int)(PcShopEntities.GetContext().Сomputer.First(x => x.NAME == c).ID_PRODUCT);
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