using System.Windows;
using System.Windows.Media;

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MyColorSlider.Width1 == 30)
            {
                MyColorSlider.Width1 = 80;
                MyColorSlider.Width2 = 100;
                MyColorSlider.Width3 = 20;
                MyColorSlider.Color1 = new SolidColorBrush(Colors.Orange);
                MyColorSlider.Color2 = new SolidColorBrush(Colors.Purple);
                MyColorSlider.Color3 = new SolidColorBrush(Colors.Cyan);
            }
            else
            {
                MyColorSlider.Width1 = 30;
                MyColorSlider.Width2 = 50;
                MyColorSlider.Width3 = 120;
                MyColorSlider.Color1 = new SolidColorBrush(Colors.AliceBlue);
                MyColorSlider.Color2 = new SolidColorBrush(Colors.MistyRose);
                MyColorSlider.Color3 = new SolidColorBrush(Colors.Goldenrod);
            }
        }
    }
}
