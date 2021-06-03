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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PcShop.Frame_Razrab
{
    /// <summary>
    /// Логика взаимодействия для KlavaRazrab.xaml
    /// </summary>
    public partial class KlavaRazrab : Page
    {
        public KlavaRazrab()
        {

            InitializeComponent();
            Table.ItemsSource = PcShopEntities.GetContext().Keyboard.ToList();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int i = (Table.SelectedItem as Keyboard).ID_PRODUCT;

            var delt = PcShopEntities.GetContext().Keyboard.Where(m => m.ID_PRODUCT == i).Single();
            PcShopEntities.GetContext().Keyboard.Remove(delt);
            PcShopEntities.GetContext().SaveChanges();
            PcShopEntities forum = new PcShopEntities();
            Table.ItemsSource = forum.Keyboard.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.DobavlenieKlava aaaasade = new PcShop.by_Razrab.Frame_Razrab.DobavlenieKlava();
            aaaasade.Show();
        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.RedactKlava fdd = new PcShop.by_Razrab.Frame_Razrab.RedactKlava((Table.SelectedItem as Keyboard).ID_PRODUCT);
            fdd.Show();


        }



        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
