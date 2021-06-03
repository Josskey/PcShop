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
    /// Логика взаимодействия для RedactKlava.xaml
    /// </summary>
    public partial class RedactKlava : Window
    {
        int id;
        public RedactKlava(int Mid)
        {
            id = Mid; 
            InitializeComponent();
            Id_cat.ItemsSource = PcShopEntities.GetContext().Keyboard.ToList();
            Keyboard ldsa = (from m in PcShopEntities.GetContext().Keyboard
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
            Keyboard ldsa = (from m in PcShopEntities.GetContext().Keyboard
                             where m.ID_PRODUCT == id
                             select m).Single();
            ldsa.NAME = Name.Text;
            ldsa.PRICE = (int)Convert.ToDouble(price.Text);
            ldsa.CHARACTERISTICS = (characteristics.Text);
            ldsa.URL = (url.Text);
            ldsa.ID_PRODUCT = (int)(PcShopEntities.GetContext().Keyboard.First(x => x.NAME == c).ID_PRODUCT);
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