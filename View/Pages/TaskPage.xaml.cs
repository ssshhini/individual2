﻿using IndividualProject_1.Core;
using IndividualProject_1.View.Pages.PageTask;
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

namespace IndividualProject_1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage1());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage2());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage3());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage4());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCore.CoreFrame?.Navigate(new TaskPage5());
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Системное оповещение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ConnectionCore.CoreFrame?.Navigate(new MainPage());
            }
        }
    }
}
