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
    /// Логика взаимодействия для CompRazrab.xaml
    /// </summary>
    public partial class CompRazrab : Page
    {
        public CompRazrab()
        {

            InitializeComponent();
            Table.ItemsSource = PcShopEntities.GetContext().Сomputer.ToList();
        }
        private void Delete_Click(object sender, RoutedEventArgs e) 
        {
            int i = (Table.SelectedItem as Сomputer).ID_PRODUCT;

            var delt = PcShopEntities.GetContext().Сomputer.Where(m => m.ID_PRODUCT == i).Single();
            PcShopEntities.GetContext().Сomputer.Remove(delt);
            PcShopEntities.GetContext().SaveChanges();
            PcShopEntities forum = new PcShopEntities();
            Table.ItemsSource = forum.Сomputer.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.DobavlenieComp asade = new PcShop.by_Razrab.Frame_Razrab.DobavlenieComp();
            asade.Show();
            
        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            PcShop.by_Razrab.Frame_Razrab.RedactComp pdsfa = new PcShop.by_Razrab.Frame_Razrab.RedactComp((Table.SelectedItem as Сomputer).ID_PRODUCT);
            pdsfa.Show();
          

        }



        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}