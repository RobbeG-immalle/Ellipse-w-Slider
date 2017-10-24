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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            vertSlider.Minimum = 0;
            vertSlider.Maximum = mijnCanvas.Height;

            horizSlider.Minimum = 0;
            horizSlider.Maximum = mijnCanvas.Width;

            vertLabel.Content = Convert.ToString(vertSlider.Value);
            horizLabel.Content = Convert.ToString(horizSlider.Value);

            CreateEllipse();
        }

        private void vertSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int vert = Convert.ToInt32(vertSlider.Value);
            vertLabel.Content = Convert.ToString(vert);

            UpdateEllipse();
        }

        private void horizSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)

        {
            int horiz = Convert.ToInt32(horizSlider.Value);
            horizLabel.Content = Convert.ToString(horiz);

            UpdateEllipse();
        }


        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Width = horizSlider.Value;
            ellipse.Height = vertSlider.Value;
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(Colors.Beige);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            mijnCanvas.Children.Add(ellipse);
        }
        private void UpdateEllipse()
        {
            ellipse.Width = horizSlider.Value;
            ellipse.Height = vertSlider.Value;
        }
    }
 }

