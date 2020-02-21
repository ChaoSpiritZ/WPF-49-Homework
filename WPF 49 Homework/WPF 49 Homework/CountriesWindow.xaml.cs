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
using System.Windows.Shapes;

namespace WPF_49_Homework
{
    /// <summary>
    /// Interaction logic for CountriesWindow.xaml
    /// </summary>
    public partial class CountriesWindow : Window
    {
        public List<Country> countries = new List<Country>();

        public CountriesWindow()
        {
            InitializeComponent();

            
            countries.Add(new Country("Germany", "Berlin", "Resources/GermanyFlag.jpg"));
            countries.Add(new Country("Israel", "Jerusalem", "Resources/IsraelFlag.jpg"));
            countries.Add(new Country("USA", "Washington", "Resources/USAFlag.jpg"));

            CountryComboBox.ItemsSource = countries;
            CountryComboBox.SelectedIndex = 0;
        }
    }

    public class Country
    {
        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public string ImagePath { get; set; }

        public Country(string countryName, string capitalCity, string imagePath)
        {
            CountryName = countryName;
            CapitalCity = capitalCity;
            ImagePath = imagePath;
        }
    }
}
