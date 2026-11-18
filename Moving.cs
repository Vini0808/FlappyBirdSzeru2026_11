using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace FlappyBirdSzeru2026_11
{
    internal class Moving
    {
        private double pipeSpeed = 4;
        private Random rnd = new Random();
        internal void PipeMoving(Canvas canvas, Rectangle pipeTop, Rectangle pipeBottom)
        {
            double x = Canvas.GetLeft(pipeTop) - pipeSpeed;

            if (x + pipeTop.Width < 0)
            {
                x = canvas.ActualWidth;
                double gapY = rnd.Next(50, 250);
                pipeTop.Height = gapY;
                Canvas.SetTop(pipeBottom, gapY + 150);
                pipeBottom.Height = canvas.ActualHeight - (gapY + 150);
            }

            Canvas.SetLeft(pipeTop, x);
            Canvas.SetLeft(pipeBottom, x);
        }
        internal void BirdMovingUp(Canvas canvas, Rectangle bird, double gravity)
        {
            double y = Canvas.GetTop(bird) + gravity;
            if (y < 0)
            {
                y = 0;
            }
            else if (y + bird.Height > canvas.ActualHeight)
            {
                y = canvas.ActualHeight - bird.Height;
            }

            if (Keyboard.IsKeyDown(Key.Space) || Keyboard.IsKeyDown(Key.Up) || Keyboard.IsKeyDown(Key.W) || Keyboard.IsKeyDown(Key.Enter))
            {
                y -= 10;
            }
            Canvas.SetTop(bird, y);
        }

        internal void BirdMovingAround(Canvas canvas, Rectangle bird)
        {
            double x = Canvas.GetLeft(bird);

            if (Keyboard.IsKeyDown(Key.Left) || Keyboard.IsKeyDown(Key.A))
            {
                x -= 5;
            }
            else if (Keyboard.IsKeyDown(Key.Right) || Keyboard.IsKeyDown(Key.D))
            {
                x += 5;
            }
            Canvas.SetLeft(bird, x);
        }

        internal void IsColliding(Rectangle bird, Rectangle pipeTop, Rectangle pipeBottom)
        {
            Rect birdRect = new Rect(Canvas.GetLeft(bird), Canvas.GetTop(bird), bird.Width, bird.Height);
            Rect pipeTopRect = new Rect(Canvas.GetLeft(pipeTop), Canvas.GetTop(pipeTop), pipeTop.Width, pipeTop.Height);
            Rect pipeBottomRect = new Rect(Canvas.GetLeft(pipeBottom), Canvas.GetTop(pipeBottom), pipeBottom.Width, pipeBottom.Height);

            if (birdRect.IntersectsWith(pipeTopRect) || birdRect.IntersectsWith(pipeBottomRect))
            {
                MessageBox.Show("Game Over!");
                Application.Current.Shutdown();
            }
        }
    }
}
