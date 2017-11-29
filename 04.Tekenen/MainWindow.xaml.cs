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

namespace _04.Tekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static bool line = true;
        private void btnLine_Click(object sender, RoutedEventArgs e)
        {
            
            Line myLine = new Line();
            int intX1 = Convert.ToInt32(txtX1.Text);
            int intX2 = Convert.ToInt32(txtX2.Text);
            int intY1 = Convert.ToInt32(txtY1.Text);
            int intY2 = Convert.ToInt32(txtY2.Text);
            int intThickness = Convert.ToInt32(txtThickness.Text);
            SolidColorBrush colour = (SolidColorBrush)new BrushConverter().ConvertFromString(txtColour.Text);
            myLine.Stroke = colour;
            myLine.X1 = intX1;
            myLine.X2 = intX2;
            myLine.Y1 = intY1;
            myLine.Y2 = intY2;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = intThickness;
            tekenen.Children.Add(myLine);

        }

        private void btnRec_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            int intThickness = Convert.ToInt32(txtThickness.Text);
            int intHeight = Convert.ToInt32(txtX1.Text);
            int intWidth = Convert.ToInt32(txtX2.Text);
            SolidColorBrush colour = (SolidColorBrush)new BrushConverter().ConvertFromString(txtColour.Text);
            rec.Fill = colour;
            rec.Stroke = Brushes.Green;
            rec.Height = intHeight;
            rec.Width = intWidth;
            rec.StrokeThickness = intThickness;
            tekenen.Children.Add(rec);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (line == true)
            {
                lblX1.Content = "Height";
                lblX2.Content = "Width";
                lblY1.Content = "Stroke colour";
                lblColour.Content = "Fill colour";
                btnLine.Visibility = Visibility.Hidden;
                btnRec.Visibility = Visibility.Visible;
                txtY2.Visibility = Visibility.Hidden;
                lblY2.Visibility = Visibility.Hidden;
                line = false;
            }
            else if (line == false)
            {
                lblX1.Content = "X1";
                lblX2.Content = "X2";
                lblY1.Content = "Y1";
                lblColour.Content = "Colour";
                btnLine.Visibility = Visibility.Visible;
                btnRec.Visibility = Visibility.Hidden;
                txtY1.Visibility = Visibility.Visible;
                txtY2.Visibility = Visibility.Visible;
                lblY2.Visibility = Visibility.Visible;
                line = true;
            }
        }
    }
}
