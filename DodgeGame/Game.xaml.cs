using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            goodie.Source = new BitmapImage(new Uri(@"/DodgeGame;component/Images/beer-7370681_1280.bmp",UriKind.Relative));
            goodie.Width = 50;
            
            gameCanvas.Children.Add(goodie);

            //goodie.Parent.SetValue("Top",Random.Shared.Next(0,740)); This didn't work
            //goodie.Parent.SetValue("Left",Random.Shared.Next(0,374));

            Canvas.SetTop(goodie, Random.Shared.Next(0, 374));
            Canvas.SetLeft(goodie, Random.Shared.Next(0, 740));            
            for (int i = 0; i < baddies.Length; i++)
            {
                baddies[i] = new Image
                {
                    Source = new BitmapImage(new Uri(@"/DodgeGame;component/Images/sugar-skull-7441361_1280.bmp", UriKind.Relative))
                };
                baddies[i].Width = 50;
                gameCanvas.Children.Add(baddies[i]);
                Canvas.SetTop(baddies[i], Random.Shared.Next(0, 374));
                Canvas.SetLeft(baddies[i], Random.Shared.Next(0, 740));
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

        public void GoodieMove(Key key)
        {
            
        }

        private void gameCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Canvas.SetLeft(gameCanvas.Children[1], Canvas.GetLeft(gameCanvas.Children[1]) - 1); //This sort of works
                ChangeText("Left");
            }
            else if (e.Key == Key.Right)
            {
                Canvas.SetLeft(gameCanvas.Children[1], Canvas.GetLeft(gameCanvas.Children[1])+1); //This sort of works
                ChangeText("Right");
            }
            else if (e.Key == Key.Up)
            {
                Canvas.SetTop(gameCanvas.Children[1], Canvas.GetTop(gameCanvas.Children[1]) - 1); //This loses focus
            }
            else if (e.Key == Key.Down)
            {
                Canvas.SetTop(gameCanvas.Children[1], Canvas.GetTop(gameCanvas.Children[1]) + 1); //This loses focus
            }
            else if (e.Key == Key.Space)
            {
                Canvas.SetTop(gameCanvas.Children[1], Random.Shared.Next(0, 374));
                Canvas.SetLeft(gameCanvas.Children[1], Random.Shared.Next(0, 740)); //This works well
            }
        }

        private void gameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            gameCanvas.Focus();
        }
    }
}
