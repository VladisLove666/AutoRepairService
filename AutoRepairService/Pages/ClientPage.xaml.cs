﻿using System;
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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        private Users _currentUser;
        public ClientPage(Users user)
        {
            InitializeComponent();
            _currentUser = user;
        }
        private void CreateRequestButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateRequestPage());
        }
    }
}
