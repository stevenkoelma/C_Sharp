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

namespace Tutorial_4
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

        private void DrawSquare_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Black);
            SetSquare(drawCanvas, color, 10, 20, 20);
            SetSquare(drawCanvas, color, 10, 20, 40);
            SetSquare(drawCanvas, color, 10, 20, 60);
                        
        }

        private void SetSquare(Canvas drawCanvas, SolidColorBrush color, double xPosition, double yPosition, double size)
        {
        Rectangle square = new Rectangle();
        square.Width = size;
        square.Height = size;
        square.Margin = new Thickness(xPosition, yPosition, 0, 0);
        square.Stroke = color;

         drawCanvas.Children.Add(square);

        }

        private void DrawCircle_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Black);
            SetCircle(drawCanvas, color, 10, 120, 40);

        }
        

        private void SetCircle(Canvas drawCanvas, SolidColorBrush color, double xPosition, double yPosition, double size)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 100;
            ellipse.Height = 50;
            ellipse.Margin = new Thickness(xPosition, yPosition, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            drawCanvas.Children.Add(ellipse);
        }

        private void DrawTriangle_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Black);
            SetTriangle(drawCanvas, color, 10, 235, 40, 40);
        }

        private void SetTriangle(Canvas drawCanvas, SolidColorBrush color, int topX, int topY, int height, int width)
        {
            DrawLine(drawCanvas, color, topX, topY, topX, topY + height);
            DrawLine(drawCanvas, color, topX, topY + height, topX + width, topY + height);
            DrawLine(drawCanvas, color, topX, topY, topX + width, topY + height);
        }

        private void DrawLine(Canvas drawCanvas, SolidColorBrush color, int startX, int startY, int endX, int endY)
        {
            Line line = new Line();
            line.X1 = startX;
            line.Y1 = startY;
            line.X2 = endX;
            line.Y2 = endY;
            line.Stroke = color;
            line.StrokeThickness = 1;
            drawCanvas.Children.Add(line);
        }

       

        
    }
    
}
