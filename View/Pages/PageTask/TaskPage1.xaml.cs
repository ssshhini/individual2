using System;
using System.Windows;
using System.Windows.Controls;

namespace IndividualProject_1.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage1.xaml
    /// </summary>
    public partial class TaskPage1 : Page
    {
        public TaskPage1()
        {
            InitializeComponent();
        }

        private void BtnGetData_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbIndex.Text) ||
                string.IsNullOrEmpty(TbCountry.Text) ||
                string.IsNullOrEmpty(TbCity.Text) ||
                string.IsNullOrEmpty(TbStreet.Text) ||
                string.IsNullOrEmpty(TbHouse.Text) ||
                string.IsNullOrEmpty(TbApartment.Text))
            {
                MessageBox.Show("Ошибка ввода данных", "Задание №1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Address address = new()
                {
                    Index = Convert.ToInt32(TbIndex.Text),
                    Country = TbCountry.Text,
                    City = TbCity.Text,
                    Street = TbStreet.Text,
                    House = TbHouse.Text,
                    Apartment = TbApartment.Text
                };

                MessageBox.Show($"Адрес: {address.Index}, {address.Country}, {address.City}, {address.Street}, {address.House}, {address.Apartment}",
                    "Задание №1", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void ClearFields()
        {
            TbIndex.Text = string.Empty;
            TbCountry.Text = string.Empty;
            TbCity.Text = string.Empty;
            TbStreet.Text = string.Empty;
            TbHouse.Text = string.Empty;
            TbApartment.Text = string.Empty;
        }
    }

    public class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
}
