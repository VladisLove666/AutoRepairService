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
    /// Логика взаимодействия для ViewRequestsPage.xaml
    /// </summary>
    public partial class ViewRequestsPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public ViewRequestsPage()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            var requests = db.Requests.ToList();
            RequestsDataGrid.ItemsSource = requests;


            foreach (var request in requests)
            {
                Console.WriteLine($"RequestID: {request.RequestID}, CarModel: {request.CarModel}");
            }
        }

        private void EditRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (RequestsDataGrid.SelectedItem is Requests selectedRequest)
            {
                NavigationService.Navigate(new EditRequestPage(selectedRequest));
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteRequestButton_Click(object sender, RoutedEventArgs e)
        {
            if (RequestsDataGrid.SelectedItem is Requests selectedRequest)
            {
                db.Requests.Remove(selectedRequest);
                db.SaveChanges();
                LoadRequests();
                MessageBox.Show("Заявка успешно удалена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заявку для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
