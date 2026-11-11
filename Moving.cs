using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FlappyBirdSzeru2026_11
{
    internal class Moving : MainWindow
    {
        private double pipeSpeed = 5;
        private Random rnd = new Random();
        public void PipeMoving()
        {
            double x = Canvas.GetLeft(PipeTop) - pipeSpeed;

            if (x + PipeTop.Width < 0)
            {
                x = GameCanvas.ActualWidth;
                double gapY = rnd.Next(50, 250);
                PipeTop.Height = gapY;
                Canvas.SetTop(PipeBottom, gapY + 150);
                PipeBottom.Height = GameCanvas.ActualHeight - (gapY + 150);
            }

            Canvas.SetLeft(PipeTop, x);
            Canvas.SetLeft(PipeBottom, x);
        }
    }
}
