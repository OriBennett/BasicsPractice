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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //myButton.FontSize = 48;
            //myButton.Content = "Welcome to the program. Click me!";
            //helloTB.Foreground = Brushes.BlueViolet;
            //helloTB.FontWeight = FontWeights.Bold;
            //TextBlock textBlock = new TextBlock();
            //textBlock.FontSize = 50;
            //textBlock.Text = "Hello";
            //textBlock.Inlines.Add(" Added new stuff behind with Inline");
            //textBlock.Inlines.Add(new Run(" Run text that I added in code behind")
            //{
            //    Foreground = Brushes.BlueViolet,
            //    TextDecorations = TextDecorations.Underline
            //});
            //textBlock.TextWrapping = TextWrapping.Wrap;
            //this.Content = textBlock;
        }

        //private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        //{
        //   //System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);  Doesn't work like in the tutorial and I'm not sure why probably because I don't have a default browser. Also might be that I'm not in framework.
        //}

        //private void mySecondButton_Click(object sender, RoutedEventArgs e)
        //{
        //    double myFontSize = myTextBox.FontSize;
        //    myTextBox.FontSize += 5;
        //    myTextBox.Text = "Hello";
        //    myTextBox.Foreground = Brushes.BlueViolet;
        //    myTextBox.Background = Brushes.Green;
        //}

        //private void rbBibi_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbBibi.Background= Brushes.Red;
        //}

        //private void rbBibi_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    rbBibi.Background = Brushes.White;

        //}

        //private void rbLapid_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbLapid.Background = Brushes.Red;

        //}

        //private void rbLapid_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    rbLapid.Background = Brushes.White;
        //}

        //private void rbBennett_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbBennett.Background = Brushes.Red;

        //}

        //private void rbBennett_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    rbBennett.Background = Brushes.White;
        //}

        //private void rbGantz_Checked(object sender, RoutedEventArgs e)
        //{
        //    rbGantz.Background = Brushes.Red;

        //}

        //private void rbGantz_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    rbGantz.Background = Brushes.White;
        //}

        private void cbToppingsChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbParent.IsChecked == true);
            Cheese.IsChecked = newVal;
            Olives.IsChecked = newVal;
            Pineapple.IsChecked = newVal;
            Tuna.IsChecked = newVal;
            GreenPepper.IsChecked = newVal;
            Jalapeno.IsChecked = newVal;
            Mushrooms.IsChecked = newVal;
        }

       
        private void cbParent_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if ((Cheese.IsChecked == true) && (Olives.IsChecked == true) && (Pineapple.IsChecked == true) && (Tuna.IsChecked == true) && (GreenPepper.IsChecked == true) && (Jalapeno.IsChecked==true) && (Mushrooms.IsChecked == true))
            {
                cbParent.IsChecked = true;
            }
            else if ((Cheese.IsChecked == false) && (Olives.IsChecked == false) && (Pineapple.IsChecked == false) && (Tuna.IsChecked == false) && (GreenPepper.IsChecked == false) && (Jalapeno.IsChecked == false) && (Mushrooms.IsChecked == false))
            {
                cbParent.IsChecked = false;
            }
            //still think that there is a better way to do this. should come back and refactor later.
        }

        private void BBQPic_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BBQPic.Source = new BitmapImage(new Uri(@"/HelloWorld;component/Images/Shipud.bmp", UriKind.Relative));
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(sliderTB != null)
            {
                sliderTB.Text = "Slider value is: " + mySlider.Value.ToString();
                sliderTB.FontSize = mySlider.Value;
            }
        }
    }
}