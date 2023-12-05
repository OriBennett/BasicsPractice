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

namespace CatYearsCodeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBlock CatAgeTB;
        public TextBox CatAgeInYears;
        
        public MainWindow()
        {
            InitializeComponent();
            myMainWindow.Height = 550;
            Image backgroundImage = new Image() { Source = new BitmapImage(new Uri("/Images/TimeCat.bmp", UriKind.Relative)) };
            TextBlock PromptText = new TextBlock() { Text = "What is your cats age? (years)" };
            CatAgeTB = new TextBlock {Text = "Your cat age is" };
            CatAgeInYears = new TextBox() {Margin = new Thickness(5,0,0,0), Width = 120 };
            StackPanel VerticalStackPanel = new StackPanel();
            StackPanel HorizontalStackPanel = new StackPanel() {Orientation = Orientation.Horizontal };
            HorizontalStackPanel.Children.Add(PromptText);
            HorizontalStackPanel.Children.Add(CatAgeInYears);
            VerticalStackPanel.Children.Add(HorizontalStackPanel);
            VerticalStackPanel.Children.Add(CatAgeTB);
            VerticalStackPanel.Children.Add(backgroundImage);
            myMainWindow.Content = VerticalStackPanel;

            CatAgeInYears.KeyUp += CatAgeInYears_KeyUp;


        }

        private void CatAgeInYears_KeyUp(object sender, KeyEventArgs e)
        {
            const double CATAGEMULTIPLIER = 5.4;
            if ((sender as TextBox) != null)
            {
                double catAge;
                if (IsNumeric((sender as TextBox).Text))
                {
                    double.TryParse((sender as TextBox).Text, out catAge);
                    CatAgeTB.Text = "Your cat is " + catAge * CATAGEMULTIPLIER + " years old.";
                }
                else
                {
                    CatAgeTB.Text = "Please enter a number";
                }
            }
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }
    }
}