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

namespace Labra11Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Animal elukka;
        public MainWindow()
        {
            InitializeComponent();
            //Omat alustukset
            elukka = new Animal();
            elukka.Name = "Musti";
            elukka.Happiness = 0;
            MyProgressBar.DataContext = elukka;
            tbAnimal.DataContext = elukka;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //TO DO lisätään olion happiness ominaisuuutta
            Animal olio = (Animal)MyProgressBar.DataContext;
            olio.Happiness++;
            
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            //Luodaan toinen elukka
            Animal kissa = new Animal();
            kissa.Name = "Misse";
            kissa.Happiness = 50;
            MyProgressBar.DataContext = kissa;
            tbAnimal.DataContext = kissa;

        }
    }
}
