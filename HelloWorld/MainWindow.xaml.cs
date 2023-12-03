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
            myButton.FontSize = 48;
            myButton.Content = "Welcome to the program. Click me!";
            helloTB.Foreground = Brushes.BlueViolet;
            helloTB.FontWeight = FontWeights.Bold;
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

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
           //System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);  Doesn't work like in the tutorial and I'm not sure why probably because I don't have a default browser. Also might be that I'm not in framework.
        }
    }
}