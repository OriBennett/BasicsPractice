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

namespace MenuDemo
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

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            myTextBox.Text = string.Empty;
        }

        private void boldButton_Click(object sender, RoutedEventArgs e)
        {
            if (myTextBox.FontWeight != FontWeights.Bold)
            {
                boldButton.FontWeight = FontWeights.Bold;
                myTextBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                myTextBox.FontWeight = FontWeights.Normal;
                boldButton.FontWeight = FontWeights.Normal;
            }
        }

        private void sizeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sizeCB.SelectedItem as ComboBoxItem != null)
            {
                int newSize;
                ComboBoxItem selectedItem = sizeCB.SelectedItem as ComboBoxItem; 
                string sizeText = (string)selectedItem.Content; //why does this only work with casting and not with a to string?
                if (int.TryParse(sizeText, out newSize))
                {
                    if (myTextBox != null)
                        myTextBox.FontSize = newSize;
                }
            }
        }
    }
}