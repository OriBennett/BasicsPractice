using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DodgeGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
            InitializeBoard();
        }
        public Game(string text)
        {
            InitializeComponent();
            ChangeText(text);
        }

        public void ChangeText(string text)
        {
            gameText.Text = text;
        }

        public void InitializeBoard()
        {
            Image goodie = new Image();
            Image[] baddies = new Image[10];
            //BBQPic.Source = new BitmapImage(new Uri(@"/HelloWorld;component/Images/Shipud.bmp", UriKind.Relative)); template for bitmaps
            goodie.Source = new BitmapImage(new Uri(@"/DodgeGame;component/Images/beer-7370681_640.bmp",UriKind.Relative));
            goodie.Width = 50;
            goodie.BeginInit();
            TextBlock textBlock = new TextBlock {Text = "TestingText", FontSize = 54 };
            this.AddVisualChild(goodie);
            this.AddVisualChild(textBlock);
            ChangeText("is"+(string)this.LogicalChildren.Current);
            //ChangeText("Changed"); Testing to see if the code reached here

            for (int i = 0; i < baddies.Length; i++)
            {
                baddies[i].Source = new BitmapImage(new Uri(@"/DodgeGame;component/Images/beer-7370681_640.bmp", UriKind.Relative));
                this.AddVisualChild(baddies[i]);
            }
        }
        //public void InitializeBoardFromSave(/*Some sort of data object with locations for goddie and baddies*/)
        //{
        //    Image goodie = new Image(/*goodieImagae*/) {/*Random location in Canvas*/ };
        //    Image[] baddies = new Image[10];

        //    for (int i = 0; i < baddies.Length; i++)
        //    {
        //        baddies[i] = new Image(/*BaddiesImage*/) {/*Random location in Canvas Not on Goodie*/ };
        //    }
        //}
    }
}
