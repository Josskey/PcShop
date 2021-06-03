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
    /// Логика взаимодействия для MichRazrab.xaml
    /// </summary>
    public partial class MichRazrab : Page
    {
        public MichRazrab()
        {

            InitializeComponent();
            Table.ItemsSource = PcShopEntities.GetContext().Mouse.ToList();
        }
        private void Delete_Click(object sender, RoutedEventArgs e) 
        {
            int i = (Table.SelectedItem as Mouse).ID_PRODUCT;

            var delt = PcShopEntities.GetContext().Mouse.Where(m => m.ID_PRODUCT == i).Single();
            PcShopEntities.GetContext().Mouse.Remove(delt);
            PcShopEntities.GetContext().SaveChanges();
            PcShopEntities forum = new PcShopEntities();
            Table.ItemsSource = forum.Mouse.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.DobavlenieMich aaasade = new PcShop.by_Razrab.Frame_Razrab.DobavlenieMich();
            aaasade.Show();
        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.RedactMich ghj= new PcShop.by_Razrab.Frame_Razrab.RedactMich((Table.SelectedItem as Mouse).ID_PRODUCT);
            ghj.Show();


        }



        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}