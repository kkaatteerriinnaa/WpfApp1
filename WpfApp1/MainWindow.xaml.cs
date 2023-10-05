using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PhotoAlbum
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] imageNames = { "image1.jpg", "image2.jpg", "image3.jpg" };

            foreach (var imageName in imageNames)
            {
                TabItem tab = new TabItem();
                tab.Header = imageName;

                Image image = new Image();
                image.Source = new BitmapImage(new Uri(imageName, UriKind.Relative));
                image.Stretch = System.Windows.Media.Stretch.Uniform;

                tab.Content = image;
                tabControl.Items.Add(tab);
            }
        }
    }
}
