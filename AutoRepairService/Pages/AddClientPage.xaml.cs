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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public AddClientPage()
        {
            InitializeComponent();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            var newClient = new Clients
            {
                FullName = FullNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text
            };

            db.Clients.Add(newClient);
            db.SaveChanges();
            MessageBox.Show("Клиент успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
