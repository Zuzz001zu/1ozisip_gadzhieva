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

namespace _1ozisip_gadzhieva.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            picture.Source = new BitmapImage(new Uri("Resources/92.jpg", UriKind.Relative));
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            picture.Source = new BitmapImage(new Uri("Resources/jetdeauFontanZheneva.jpg", UriKind.Relative));
        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Str1());
        }
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Str2());
        }
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new User());
        }
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());
        }
        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Biz());
        }

    }
}
