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
    /// Логика взаимодействия для AddMechanicPage.xaml
    /// </summary>
    public partial class AddMechanicPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public AddMechanicPage()
        {
            InitializeComponent();
        }

        private void AddMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            var newMechanic = new Mechanics
            {
                FullName = FullNameTextBox.Text
            };

            db.Mechanics.Add(newMechanic);
            db.SaveChanges();
            MessageBox.Show("Механик успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
