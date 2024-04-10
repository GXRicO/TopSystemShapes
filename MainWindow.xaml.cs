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

namespace TopSystemShapes
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawGeometricFigures();
        }

        private void DrawGeometricFigures()
        {
            Canvas canvas =new Canvas();

            Ellipse circle = new Ellipse
            {
                Width = 150,
                Height = 150,
                Fill = Brushes.AliceBlue
            };

            Canvas.SetLeft(circle, 50);
            Canvas.SetTop(circle, 50);
            canvas.Children.Add(circle);

            Rectangle rectangle = new Rectangle
            {
                Width = 150,
                Height = 100,
                Fill = Brushes.Yellow
            };
            Canvas.SetLeft(rectangle, 250);
            Canvas.SetTop(rectangle, 50);
            canvas.Children.Add(rectangle);


            Rectangle squarerectangle = new Rectangle
            {
                Width = 100,
                Height = 100,
                Fill = Brushes.Green
            };

            Canvas.SetLeft(squarerectangle, 450);
            Canvas.SetTop(squarerectangle, 50);
            canvas.Children.Add(squarerectangle);

            Ellipse ellipse = new Ellipse
            {
                Width = 100,
                Height = 160,
                Fill = Brushes.Red
            };

            Canvas.SetLeft(ellipse, 600);
            Canvas.SetTop(ellipse, 50);
            canvas.Children.Add(ellipse);

            Polygon triangle = new Polygon
            {
                Fill = Brushes.Orange,
                Points = new PointCollection()
                {
                   new Point(0,0),
                   new Point(150,0), 
                   new Point(0,100)
                }
            };

            Canvas.SetLeft(triangle, 800);
            Canvas.SetTop(triangle, 50);
            canvas.Children.Add(triangle);

            Polygon hexagon = new Polygon
            {
                Fill = Brushes.Blue,
                Points = new PointCollection()
                {
                    new Point(100,0),
                    new Point(200, 50),
                    new Point(200, 150),
                    new Point(100,200),
                    new Point(0,150),
                    new Point (0,50)
                }
            };

            Canvas.SetLeft(hexagon, 400);
            Canvas.SetTop (hexagon, 250);
            canvas.Children.Add(hexagon);

             Content= canvas;

        }


    }
}
