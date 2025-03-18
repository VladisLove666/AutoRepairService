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
    /// Логика взаимодействия для MechanicsPage.xaml
    /// </summary>
    public partial class MechanicsPage : Page
    {
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public MechanicsPage()
        {
            InitializeComponent();
            LoadMechanics();
        }

        private void LoadMechanics()
        {
            MechanicsDataGrid.ItemsSource = db.Mechanics.ToList();
        }

        private void AddMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMechanicPage());
        }

        private void EditMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            if (MechanicsDataGrid.SelectedItem is Mechanics selectedMechanic)
            {
                NavigationService.Navigate(new EditMechanicPage(selectedMechanic));
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите механика для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteMechanicButton_Click(object sender, RoutedEventArgs e)
        {
            if (MechanicsDataGrid.SelectedItem is Mechanics selectedMechanic)
            {
                db.Mechanics.Remove(selectedMechanic);
                db.SaveChanges();
                LoadMechanics();
                MessageBox.Show("Механик успешно удален!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите механика для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
