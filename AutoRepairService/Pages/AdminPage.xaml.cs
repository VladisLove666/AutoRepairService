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

namespace AutoRepairService.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private Users _currentUser;
        public AdminPage(Users user)
        {
            InitializeComponent();
            _currentUser = user;
        }
        private void ViewRequestsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewRequestsPage());
        }

        private void ViewClientsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientsPage());
        }

        private void ViewMechanicsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MechanicsPage());
        }

        private void ViewReportsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReportsPage());
        }
    }
}
