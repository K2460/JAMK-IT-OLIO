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

namespace WPFtehtäviä
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CarsLaskuri = 0;
        private int TrucksLaskuri = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            //lisää 1 auto
            CarsLaskuri++;
            //näyttää lisäyksen txt1
            txt1.Text = " " + CarsLaskuri;
        }

        private void btnTrucks_Click(object sender, RoutedEventArgs e)
        {
            //lisää 1 rekka
            TrucksLaskuri++;
            //näyttää lisäyksen txt2
            txt2.Text = " " + TrucksLaskuri;
        }
    }
}