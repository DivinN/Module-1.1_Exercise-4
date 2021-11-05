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

namespace Module_1._1_Exercise_4_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Dollar(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDolInUI.Text);
            double sumDollar = Convert.ToDouble(sumDolInUI.Text);
            double resDollar = rateDollar * sumDollar;
            resSumDolInUI.Text = resDollar.ToString();
        }

        private void Button_Euro(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEuroInUI.Text);
            double sumEuro = Convert.ToDouble(sumEuroInUI.Text);
            double resEuro = rateEuro * sumEuro;
            resSumEuroInUI.Text = resEuro.ToString();
        }

        private void Button_Hryvnia(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rateHryvniaInUI.Text);
            double sumHryvnia = Convert.ToDouble(sumHryvniaInUI.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSumHryvniaInUI.Text = resHryvnia.ToString();
        }

        private void Button_Dramas(object sender, RoutedEventArgs e)
        {
            double rateDramas = Convert.ToDouble(rateDramasInUI.Text);
            double sumDramas = Convert.ToDouble(sumDramasInUI.Text);
            double resDramas = rateDramas * sumDramas;
            resSumDramasInUI.Text = resDramas.ToString();
        }

        private void Button_Feet(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(rateFeetInUI.Text);
            double sumFeet = Convert.ToDouble(sumFeetInUI.Text);
            double resFeet = rateFeet * sumFeet;
            resSumFeetInUI.Text = resFeet.ToString();
        }

        private void Button_Inches(object sender, RoutedEventArgs e)
        {
            double rateInches = Convert.ToDouble(rateInchesInUI.Text);
            double sumInches = Convert.ToDouble(sumInchesInUI.Text);
            double resInches = rateInches * sumInches;
            resSumInchesInUI.Text = resInches.ToString();
        }

        private void Button_Miles(object sender, RoutedEventArgs e)
        {
            double rateMiles = Convert.ToDouble(rateMilesInUI.Text);
            double sumMiles = Convert.ToDouble(sumMilesInUI.Text);
            double resMiles = rateMiles * sumMiles;
            resSumMilesInUI.Text = resMiles.ToString();
        }

        private void Button_Yards(object sender, RoutedEventArgs e)
        {
            double rateYards = Convert.ToDouble(rateYardsInUI.Text);
            double sumYards = Convert.ToDouble(sumYardsInUI.Text);
            double resYards = rateYards * sumYards;
            resSumYardsInUI.Text = resYards.ToString();
        }


    }
}
