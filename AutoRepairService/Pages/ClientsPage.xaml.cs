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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public ClientsPage()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            ClientsDataGrid.ItemsSource = db.Clients.ToList();
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddClientPage());
        }

        private void EditClientButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem is Clients selectedClient)
            {
                NavigationService.Navigate(new EditClientPage(selectedClient));
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteClientButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem is Clients selectedClient)
            {
                db.Clients.Remove(selectedClient);
                db.SaveChanges();
                LoadClients();
                MessageBox.Show("Клиент успешно удален!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
