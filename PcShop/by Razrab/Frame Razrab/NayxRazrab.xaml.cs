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
    /// Логика взаимодействия для NayxRazrab.xaml
    /// </summary>
    public partial class NayxRazrab : Page
    {
        public NayxRazrab()
        {

            InitializeComponent();
            Table.ItemsSource = PcShopEntities.GetContext().Headset.ToList();
        }
        private void Delete_Click(object sender, RoutedEventArgs e) 
        {
            int i = (Table.SelectedItem as Headset).ID_PRODUCT;

            var delt = PcShopEntities.GetContext().Headset.Where(m => m.ID_PRODUCT == i).Single();
            PcShopEntities.GetContext().Headset.Remove(delt);
            PcShopEntities.GetContext().SaveChanges();
            PcShopEntities forum = new PcShopEntities();
            Table.ItemsSource = forum.Headset.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.DobavlenieNayx aasade = new PcShop.by_Razrab.Frame_Razrab.DobavlenieNayx();
            aasade.Show();
        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.RedactNayx gd = new PcShop.by_Razrab.Frame_Razrab.RedactNayx((Table.SelectedItem as Headset).ID_PRODUCT);
            gd.Show();


        }



        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}