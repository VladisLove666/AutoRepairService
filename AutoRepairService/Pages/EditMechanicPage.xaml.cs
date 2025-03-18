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
    /// Логика взаимодействия для EditMechanicPage.xaml
    /// </summary>
    public partial class EditMechanicPage : Page
    {
        private Mechanics _currentMechanic;
        public AutoRepairServiceEntities db = new AutoRepairServiceEntities();

        public EditMechanicPage(Mechanics mechanic)
        {
            InitializeComponent();
            _currentMechanic = mechanic;
            LoadMechanicData();
        }

        private void LoadMechanicData()
        {
            MechanicIDTextBox.Text = _currentMechanic.MechanicID.ToString();
            FullNameTextBox.Text = _currentMechanic.FullName;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            _currentMechanic.FullName = FullNameTextBox.Text;

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
