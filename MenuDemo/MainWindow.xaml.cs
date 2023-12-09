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
                miBold.FontWeight = FontWeights.Bold;
                miBold.IsChecked = true;
            }
            else
            {
                myTextBox.FontWeight = FontWeights.Normal;
                boldButton.FontWeight = FontWeights.Normal;
                miBold.FontWeight = FontWeights.Normal;
                miBold.IsChecked = false;
            }
        }

        private void sizeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sizeCB.SelectedItem as ComboBoxItem != null)
            {
                int newSize;
                ComboBoxItem selectedItem = sizeCB.SelectedItem as ComboBoxItem; //Isn't null, I just checked
                string sizeText = (string)selectedItem.Content; //why does this only work with casting and not with a to string?
                if (int.TryParse(sizeText, out newSize))
                {
                    if (myTextBox != null)
                        myTextBox.FontSize = newSize;
                }
            }
        }

        private void ProgressButton1_Click(object sender, RoutedEventArgs e)
        {
            myProgressBar.Value += 1;
            CheckDone();
        }

        private void ProgressButton5_Click(object sender, RoutedEventArgs e)
        {
            myProgressBar.Value += 5;
            CheckDone();
        }

        private void ProgressButton20_Click(object sender, RoutedEventArgs e)
        {
            myProgressBar.Value += 20;
            CheckDone();
        }

        private void ProgressButtonReset_Click(object sender, RoutedEventArgs e)
        {
            myProgressBar.Value = 0;
            StatusText.Content = "Loading...";
        }

        private void CheckDone()
        {
            if (myProgressBar.Value == 100)
            {
                StatusText.Content = "Done!";
            }
        }
    }
}