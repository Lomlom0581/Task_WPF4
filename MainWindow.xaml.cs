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

namespace Task_WPF4
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

        private void DollarButton_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDollar.Text);
            double sum = Convert.ToDouble(sumDollar.Text);
            double result = rate * sum;
            resultDollar.Text = result.ToString();
        }

        private void EuroButton_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEuro.Text);
            double sum = Convert.ToDouble(sumEuro.Text);
            double result = rate * sum;
            resultEuro.Text = result.ToString();
        }

        private void GrivnaButton_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateGrivna.Text);
            double sum = Convert.ToDouble(sumGrivna.Text);
            double result = rate * sum;
            resultGrivna.Text = result.ToString();
        }

        private void DrahmaButton_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDrahma.Text);
            double sum = Convert.ToDouble(sumDrahma.Text);
            double result = rate * sum;
            resultDrahma.Text = result.ToString();
        }

        private void InchButton_Click(object sender, RoutedEventArgs e)
        {
            double inches = Convert.ToDouble(Inches.Text);
            double meters = inches * 0.0254;
            MetersByInch.Text = meters.ToString();

        }

        private void FootButton_Click(object sender, RoutedEventArgs e)
        {
            double feet = Convert.ToDouble(Feet.Text);
            double meters = feet * 0.3048;
            MetersByFoot.Text = meters.ToString();

        }

        private void MileButton_Click(object sender, RoutedEventArgs e)
        {
            double miles = Convert.ToDouble(Miles.Text);
            double meters = miles * 1609.34;
            MetersByMile.Text = meters.ToString();

        }

        private void VerstaButton_Click(object sender, RoutedEventArgs e)
        {
            double verst = Convert.ToDouble(Verst.Text);
            double meters = verst * 1067;
            MetersByVersta.Text = meters.ToString();

        }
    }
}
