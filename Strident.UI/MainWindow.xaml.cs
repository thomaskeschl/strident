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
using Strident.Core;

namespace Strident.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NoiseGeneratorFactory factory = new NoiseGeneratorFactory();
            INoiseGenerator generator = factory.createSimplexGenerator();

            WriteableBitmap bitmap = new WriteableBitmap(256, 256, 300, 300, PixelFormats.Bgra32, null);

            for (int y = 0; y < 256; y++)
            {
                for (int x = 0; x < 256; x++)
                {
                    double noise = (generator.noiseAt(x, y) + 1.0) * 127.5;
                    byte argb = Convert.ToByte(noise);
                    bitmap.setPixel(x, y, Color.FromArgb(255, argb, argb, argb));
                }
            }
            
            image.Source = bitmap;
        }
    }
}
