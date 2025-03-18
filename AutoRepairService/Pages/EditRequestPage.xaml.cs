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
    /// Логика взаимодействия для EditRequestPage.xaml
    /// </summary>
    public partial class EditRequestPage : Page
    {
        private Requests _currentRequest;
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public EditRequestPage(Requests request)
        {
            InitializeComponent();
            _currentRequest = request;
            LoadRequestData();
        }

        private void LoadRequestData()
        {
            RequestIDTextBox.Text = _currentRequest.RequestID.ToString();
            CarModelTextBox.Text = _currentRequest.CarModel;
            ClientNameTextBox.Text = _currentRequest.ClientName;
            DescriptionTextBox.Text = _currentRequest.Description;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            _currentRequest.CarModel = CarModelTextBox.Text;
            _currentRequest.ClientName = ClientNameTextBox.Text;
            _currentRequest.Description = DescriptionTextBox.Text;

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
