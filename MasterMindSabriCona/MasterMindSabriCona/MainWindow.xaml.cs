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

            GenerateAndSetRandomColors();


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


        private Ellipse CreateColorEllipse(SolidColorBrush color)
        {
            return new Ellipse
            {
                Width = 20,
                Height = 20,
                Fill = color,
                Margin = new Thickness(2)
            };
        }

        private void check_code_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.SelectedItem == null || ComboBox2.SelectedItem == null || ComboBox3.SelectedItem == null || ComboBox4.SelectedItem == null)
            {
                MessageBox.Show("Please fill all 4 colors.", "Missing Selection", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var color1 = (ComboBox1.SelectedItem as ComboBoxItem)?.Background as SolidColorBrush;
            var color2 = (ComboBox2.SelectedItem as ComboBoxItem)?.Background as SolidColorBrush;
            var color3 = (ComboBox3.SelectedItem as ComboBoxItem)?.Background as SolidColorBrush;
            var color4 = (ComboBox4.SelectedItem as ComboBoxItem)?.Background as SolidColorBrush;

            StackPanel colorCombination = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(5) };
            colorCombination.Children.Add(CreateColorEllipse(color1));
            colorCombination.Children.Add(CreateColorEllipse(color2));
            colorCombination.Children.Add(CreateColorEllipse(color3));
            colorCombination.Children.Add(CreateColorEllipse(color4));
            PreviousCombinationsPanel.Children.Add(colorCombination);

        }

        private void GenerateAndSetRandomColors()
        {
            string[] colorNames = { "Red", "Yellow", "Blue", "Green", "Orange", "White" };
            Random random = new Random();

            string randomColor1 = colorNames[random.Next(colorNames.Length)];
            string randomColor2 = colorNames[random.Next(colorNames.Length)];
            string randomColor3 = colorNames[random.Next(colorNames.Length)];
            string randomColor4 = colorNames[random.Next(colorNames.Length)];

            this.Title = $"Generated Colors: {randomColor1}, {randomColor2}, {randomColor3}, {randomColor4}";

        }

    }
}
