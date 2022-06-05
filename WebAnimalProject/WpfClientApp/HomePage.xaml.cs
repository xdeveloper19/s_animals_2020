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

namespace WpfClientApp
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public enum AnimalType
        {
            Animal, Mammal, Anti, Bird
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Animal(object sender, RoutedEventArgs e)
        {
            // View Page
            StaticAnimal.TypeOfAnimal = AnimalType.Animal;
            AnimalPage expenseReportPage = new AnimalPage();
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Mammal(object sender, RoutedEventArgs e)
        {
            // View Page
            StaticAnimal.TypeOfAnimal = AnimalType.Mammal;
            AnimalPage expenseReportPage = new AnimalPage();
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Anti(object sender, RoutedEventArgs e)
        {
            // View Page
            StaticAnimal.TypeOfAnimal = AnimalType.Anti;
            AnimalPage expenseReportPage = new AnimalPage();
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Bird(object sender, RoutedEventArgs e)
        {
            // View Page
            StaticAnimal.TypeOfAnimal = AnimalType.Bird;
            AnimalPage expenseReportPage = new AnimalPage();
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}
