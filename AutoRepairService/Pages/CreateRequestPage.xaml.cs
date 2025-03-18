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
    /// Логика взаимодействия для CreateRequestPage.xaml
    /// </summary>
    public partial class CreateRequestPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();
        public CreateRequestPage()
        {
            InitializeComponent();
        }
        private void SubmitRequestButton_Click(object sender, RoutedEventArgs e)
        {
            var newRequest = new Requests
            {
                CarModel = CarModelTextBox.Text,
                ClientName = ClientNameTextBox.Text,
                Description = DescriptionTextBox.Text,
                RequestDate = DateTime.Now,
                Status = "Новая",
                Priority = 1
            };

            db.Requests.Add(newRequest);
            db.SaveChanges();
            MessageBox.Show("Заявка успешно создана!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
