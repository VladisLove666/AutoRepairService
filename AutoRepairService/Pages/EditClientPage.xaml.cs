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
    /// Логика взаимодействия для EditClientPage.xaml
    /// </summary>
    public partial class EditClientPage : Page
    {
        private Clients _currentClient;
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public EditClientPage(Clients client)
        {
            InitializeComponent();
            _currentClient = client;
            LoadClientData();
        }

        private void LoadClientData()
        {
            ClientIDTextBox.Text = _currentClient.ClientID.ToString();
            FullNameTextBox.Text = _currentClient.FullName;
            PhoneNumberTextBox.Text = _currentClient.PhoneNumber;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            _currentClient.FullName = FullNameTextBox.Text;
            _currentClient.PhoneNumber = PhoneNumberTextBox.Text;

            db.SaveChanges();
            MessageBox.Show("Изменения успешно сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
