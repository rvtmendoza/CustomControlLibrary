using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfCustomControlLibrary
{
    public class Tiles : Button
    {
        static Tiles()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Tiles), new FrameworkPropertyMetadata(typeof(Tiles)));
        }

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            "ImageSource", typeof(ImageSource), typeof(Tiles), new PropertyMetadata(default(ImageSource)));

        public ImageSource ImageSource
        {
            get { return (ImageSource) GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
    }
}