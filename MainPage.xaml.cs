using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using Ejercicio1.Resources;

namespace Ejercicio1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }
       
        private void uno(object sender, RoutedEventArgs e)
        {
           /* var radio = sender as RadioButton;
            if (radio.IsChecked!=null)
            {
                SolidColorBrush nuevo = new SolidColorBrush();
                nuevo.Color = Colors.Yellow;
                r1.Fill = nuevo;
            }*/

            if (RadioButton.IsCheckedProperty != null)
            {
                SolidColorBrush nuevo = new SolidColorBrush();
                nuevo.Color = Colors.Yellow;
                r1.Fill = nuevo;
            }
        }

        private void dos(object sender, RoutedEventArgs e)
        {
            if (RadioButton.IsCheckedProperty != null)
            {
                SolidColorBrush azul = new SolidColorBrush();
                azul.Color = Colors.Blue;
                r1.Fill = azul;
            }
        }

        private void tres(object sender, RoutedEventArgs e)
        {
            SolidColorBrush rojo = new SolidColorBrush();
            rojo.Color = Colors.Red;
            r1.Fill = rojo;
        }

    }
}