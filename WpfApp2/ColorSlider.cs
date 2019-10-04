using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    public class ColorSlider : Slider
    {
        public static readonly DependencyProperty Width1Property = DependencyProperty.Register("Width1", typeof(double), typeof(ColorSlider), new UIPropertyMetadata(0.0));
        [TypeConverter(typeof(LengthConverter))]
        public double Width1
        {
            get { return (double)GetValue(Width1Property); }
            set { SetValue(Width1Property, value); }
        }

        public static readonly DependencyProperty Width2Property = DependencyProperty.Register("Width2", typeof(double), typeof(ColorSlider), new UIPropertyMetadata(0.0));
        [TypeConverter(typeof(LengthConverter))]
        public double Width2
        {
            get { return (double)GetValue(Width2Property); }
            set { SetValue(Width2Property, value); }
        }

        public static readonly DependencyProperty Width3Property = DependencyProperty.Register("Width3", typeof(double), typeof(ColorSlider), new UIPropertyMetadata(0.0));
        [TypeConverter(typeof(LengthConverter))]
        public double Width3
        {
            get { return (double)GetValue(Width3Property); }
            set { SetValue(Width3Property, value); }
        }

        public static readonly DependencyProperty Color1Property = DependencyProperty.Register("Color1", typeof(Brush), typeof(ColorSlider), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));
        public Brush Color1
        {
            get { return (Brush)GetValue(Color1Property); }
            set { SetValue(Color1Property, value); }
        }

        public static readonly DependencyProperty Color2Property = DependencyProperty.Register("Color2", typeof(Brush), typeof(ColorSlider), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));
        public Brush Color2
        {
            get { return (Brush)GetValue(Color2Property); }
            set { SetValue(Color2Property, value); }
        }

        public static readonly DependencyProperty Color3Property = DependencyProperty.Register("Color3", typeof(Brush), typeof(ColorSlider), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));
        public Brush Color3
        {
            get { return (Brush)GetValue(Color3Property); }
            set { SetValue(Color3Property, value); }
        }
    }
}
