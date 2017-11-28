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
using MahApps.Metro.Controls;
using System.IO;
namespace Galery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Arikatamo\Documents\Case\Нова папка\Hearts");
            foreach (var item in dir.GetFiles())
            {
  
                Image images = new Image();
                images.Source = new BitmapImage(new Uri(@"C:\Users\Arikatamo\Documents\Case\Нова папка\Hearts\" + item));
                images.RenderSize = new Size(100, 100);
                images.Margin = new Thickness(10, 10, 10, 10);
                Image_Galery.Children.Add(images);
   
               }
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
