﻿using System;
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
            //gameText.Text = text;
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

        //private void gameCanvas_KeyDown(object sender, KeyEventArgs e) //Trying something new
        //{
        //    if (e.Key == Key.Left)
        //    {
        //        Canvas.SetLeft(gameCanvas.Children[1], Canvas.GetLeft(gameCanvas.Children[1]) - 1); //This sort of works and only works every second keydown
        //        ChangeText("Left");
        //        gameCanvas.Focus();
        //    }
        //    else if (e.Key == Key.Right)
        //    {
        //        Canvas.SetLeft(gameCanvas.Children[1], Canvas.GetLeft(gameCanvas.Children[1])+1); //This sort of works and only works every second keydown
        //        ChangeText("Right");
        //        gameCanvas.Focus();
        //    }
        //    else if (e.Key == Key.Up)
        //    {
        //        Canvas.SetTop(gameCanvas.Children[1], Canvas.GetTop(gameCanvas.Children[1]) - 1); //This loses focus
        //        gameCanvas.Focus();
        //    }
        //    else if (e.Key == Key.Down)
        //    {
        //        Canvas.SetTop(gameCanvas.Children[1], Canvas.GetTop(gameCanvas.Children[1]) + 1); //This loses focus
        //        gameCanvas.Focus();
        //    }
        //    else if (e.Key == Key.Space)
        //    {
        //        Canvas.SetTop(gameCanvas.Children[1], Random.Shared.Next(0, 374));
        //        Canvas.SetLeft(gameCanvas.Children[1], Random.Shared.Next(0, 740)); //This works well
        //    }
        //    gameCanvas.Focus();
        //}

        private void gameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            gameCanvas.Focus();
        }
        // Define flags for movement directions
        private bool movingLeft, movingRight, movingUp, movingDown;

        private void gameCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            // Set flags based on the pressed keys
            if (e.Key == Key.Left)
            {
                movingLeft = true;
            }
            else if (e.Key == Key.Right)
            {
                movingRight = true;
            }
            else if (e.Key == Key.Up)
            {
                movingUp = true;
            }
            else if (e.Key == Key.Down)
            {
                movingDown = true;
            }
            else if (e.Key == Key.Space) // jump to random space
            {
                Canvas.SetTop(gameCanvas.Children[1], Random.Shared.Next(0, 374));
                Canvas.SetLeft(gameCanvas.Children[1], Random.Shared.Next(0, 740));
            }
            else if (e.Key == Key.PageUp)
            {
                movingUp = true;
                movingRight=true;
            }
            else if(e.Key == Key.PageDown) 
            { 
                movingDown = true;
                movingRight = true;            
            }
            else if( e.Key == Key.Home)
            {
                movingLeft=true;
                movingUp=true;
            }
            else if (e.Key == Key.End)
            {
                movingLeft = true;
                movingDown=true;
            }

            // Handle diagonal movement
            UpdatePosition();
        }

        private void gameCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            // Clear flags when keys are released
            if (e.Key == Key.Left)
            {
                movingLeft = false;
            }
            else if (e.Key == Key.Right)
            {
                movingRight = false;
            }
            else if (e.Key == Key.Up)
            {
                movingUp = false;
            }
            else if (e.Key == Key.Down)
            {
                movingDown = false;
            }
            else if (e.Key == Key.PageUp)
            {
                movingUp = false;
                movingRight = false;
            }
            else if (e.Key == Key.PageDown)
            {
                movingDown = false;
                movingRight = false;
            }
            else if (e.Key == Key.Home)
            {
                movingLeft = false;
                movingUp = false;
            }
            else if (e.Key == Key.End)
            {
                movingLeft = false;
                movingDown = false;
            }


            // Handle diagonal movement
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            const double SPEED = 1.5; // Sets goodie speed here

            // Update position based on flags
            if (movingLeft && movingUp)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) - SPEED);
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) - SPEED);
            }
            else if (movingLeft && movingDown)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) - SPEED);
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) + SPEED);
            }
            else if (movingRight && movingUp)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) + SPEED);
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) - SPEED);
            }
            else if (movingRight && movingDown)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) + SPEED);
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) + SPEED);
            }
            // Handle single direction movement if needed
            else if (movingLeft)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) - SPEED);
            }
            else if (movingRight)
            {
                Canvas.SetLeft(gameCanvas.Children[0], Canvas.GetLeft(gameCanvas.Children[0]) + SPEED);
            }
            else if (movingUp)
            {
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) - SPEED);
            }
            else if (movingDown)
            {
                Canvas.SetTop(gameCanvas.Children[0], Canvas.GetTop(gameCanvas.Children[0]) + SPEED);
            }

            EnemiesMove();
        }
        public void EnemiesMove()
        {
            const double SPEED = 1.0; // Sets Baddies speed here

            for (int i=1; i<=10; i++) //this will need changing because I'm going to remove enemies
            {
                if (Canvas.GetTop(gameCanvas.Children[i]) < Canvas.GetTop(gameCanvas.Children[0]))
                {
                    Canvas.SetTop(gameCanvas.Children[i], Canvas.GetTop(gameCanvas.Children[i]) + SPEED);
                }
                else
                {
                    Canvas.SetTop(gameCanvas.Children[i], Canvas.GetTop(gameCanvas.Children[i]) - SPEED);
                }

                if (Canvas.GetLeft(gameCanvas.Children[i]) < Canvas.GetLeft(gameCanvas.Children[0]))
                {
                    Canvas.SetLeft(gameCanvas.Children[i], Canvas.GetLeft(gameCanvas.Children[i]) + SPEED);
                }
                else
                {
                    Canvas.SetLeft(gameCanvas.Children[i], Canvas.GetLeft(gameCanvas.Children[i]) - SPEED);
                }            
            }
            CheckCollisions();
        }
        public void CheckCollisions()
        {
            // will remove enemies from canvas if they collide, also will give game over if hero has collided
        }
    }
}
