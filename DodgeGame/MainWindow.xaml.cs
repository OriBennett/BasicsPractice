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
using System.Xml.Linq;

namespace DodgeGame
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

        private void menuNew_Click(object sender, RoutedEventArgs e)
        {
            //Will start a new game
            gameFrame.Content = new Game();
        }
        private void menuLoad_Click(object sender, RoutedEventArgs e)
        {
            ////Will load saved game if possible and if not, ask to start a new game
            //gameFrame.Content = new Game(/*with stuff in here so it loads or maybe some other way to load*/);
            ////Maybe create the game, then add stuff then change content
            private Game _game = new Game("Saved Game");
            //Game.ChangeText = "Saved Game";

        }
        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            //Will save the game to a file
        }
    }
}