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

namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush myBrush = new LinearGradientBrush();
            myBrush.GradientStops.Add(new GradientStop(Colors.Blue, counter*0.01));
            myBrush.GradientStops.Add(new GradientStop(Colors.Orange, counter * 0.01));
            myBrush.GradientStops.Add(new GradientStop(Colors.Red, counter * 0.02));

            Button but = new Button();
            but.Content = "click"+ ++counter;
            but.Click += Button_Click;
            but.Background = myBrush;
            panel.Children.Add(but);
        }

        
    }
}
