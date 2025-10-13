using ML_Gaussian_distribution.ML;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ML_Gaussian_distribution;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();


        string path = AppDomain.CurrentDomain.BaseDirectory;
        GenerateCoordinate generateCoordinate = new GenerateCoordinate(path);
        generateCoordinate.generatePoints();

        string[] lines = File.ReadAllLines(path+@"\Numbers.txt");
        double x, y;
        string[] words;
        int zone;
        Ellipse point;
        for (int i = 0; i < lines.Length; i++)
        {
            words = lines[i].Split(',');

            x = double.Parse(words[0]);
            y = double.Parse(words[1]);
            zone = int.Parse(words[2]);
            point = new Ellipse
            {
                Width = 3,
                Height = 3,
            };
            switch (zone)
            {
                case 0:
                    point.Fill = Brushes.Red;
                    break;
                case 1:
                    point.Fill = Brushes.Green;
                    break;
                case 2:
                    point.Fill = Brushes.Blue;
                    break;

                case 3:
                    point.Fill = Brushes.Aqua;
                    break;

                case 4:
                    point.Fill = Brushes.Brown;
                    break;

                case 5:
                    point.Fill = Brushes.Magenta;
                    break;
            }
            Canvas.SetLeft(point, 300 + x);
            Canvas.SetTop(point, 300 - y);
            canvas.Children.Add(point);
        }
        //rectangle(180, 220, 10, 10);
        //rectangle(-100, 110, 15, 10);
        //rectangle(210, -150, 5, 20);

        rectangle(-180, -180, 10, 5);
        rectangle(-180, 180, 5, 4);
        rectangle(180, 180, 4, 10);
        rectangle(180, -180, 4, 10);
        rectangle(0, 0, 5, 5);
        rectangle(0, 200, 5, 5);
    }
    private void rectangle(double x, double y, double latime, double inaltime)
    {
        x = x - latime;
        y = y + inaltime;

        latime = latime * 2;
        inaltime = inaltime * 2;

        x = 300 + x;
        y = 300 - y;

        Rectangle dreptunghi = new Rectangle
        {
            Width = latime,
            Height = inaltime,
            Stroke = Brushes.Black,
            StrokeThickness = 2
        };

        Canvas.SetLeft(dreptunghi, x);
        Canvas.SetTop(dreptunghi, y);

        canvas.Children.Add(dreptunghi);
    }
}