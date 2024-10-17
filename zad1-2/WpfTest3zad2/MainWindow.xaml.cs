using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest3zad2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changing the value of slider changes size of the brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = (sender as System.Windows.Controls.Slider);
            double slValue = slider.Value;

            InkAttr.Height = slValue;
            InkAttr.Width = slValue;
        }


        /// <summary>
        /// Changing color of the brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            var cbItem = (sender as System.Windows.Controls.ComboBoxItem);
            string cbName = cbItem.Content.ToString();

            if (cbName == "Red") InkAttr.Color=Color.FromRgb(255,0,0);              // Red
            else if (cbName == "Green") InkAttr.Color = Color.FromRgb(0, 255, 0);   // Green
            else if (cbName == "Blue") InkAttr.Color = Color.FromRgb(0, 0, 255);    // Blue
        }

        private void rbDraw_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void rbEdit_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.Select;
        }

        private void rbDelete_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }
}
