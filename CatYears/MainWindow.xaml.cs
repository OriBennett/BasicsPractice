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

namespace CatYears
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