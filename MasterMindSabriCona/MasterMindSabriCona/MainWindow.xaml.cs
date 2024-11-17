
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MasterMindSabriCona
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBox1.SelectionChanged += ComboBox1_SelectionChanged;
            ComboBox2.SelectionChanged += ComboBox2_SelectionChanged;
            ComboBox3.SelectionChanged += ComboBox3_SelectionChanged;
            ComboBox4.SelectionChanged += ComboBox4_SelectionChanged;

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem is ComboBoxItem selectedItem)
            {
                var selectedColor = (selectedItem.Background as SolidColorBrush)?.Color;
                if (selectedColor.HasValue)
                {
                    Ellipse1.Fill = new SolidColorBrush(selectedColor.Value);
                    ComboBox1.Background = new SolidColorBrush(selectedColor.Value);
                    ComboBox1.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox2.SelectedItem is ComboBoxItem selectedItem)
            {
                var selectedColor = (selectedItem.Background as SolidColorBrush)?.Color;
                if (selectedColor.HasValue)
                {
                    Ellipse2.Fill = new SolidColorBrush(selectedColor.Value);
                    ComboBox2.Background = new SolidColorBrush(selectedColor.Value);
                    ComboBox2.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox3.SelectedItem is ComboBoxItem selectedItem)
            {
                var selectedColor = (selectedItem.Background as SolidColorBrush)?.Color;
                if (selectedColor.HasValue)
                {
                    Ellipse3.Fill = new SolidColorBrush(selectedColor.Value);
                    ComboBox3.Background = new SolidColorBrush(selectedColor.Value);
                    ComboBox3.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox4.SelectedItem is ComboBoxItem selectedItem)
            {
                var selectedColor = (selectedItem.Background as SolidColorBrush)?.Color;
                if (selectedColor.HasValue)
                {
                    Ellipse4.Fill = new SolidColorBrush(selectedColor.Value);
                    ComboBox4.Background = new SolidColorBrush(selectedColor.Value);
                    ComboBox4.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
        }
    }
}











