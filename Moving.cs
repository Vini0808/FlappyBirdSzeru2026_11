using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace FlappyBirdSzeru2026_11
{
    internal class Moving
    {
        private double pipeSpeed = 5;
        private Random rnd = new Random();
        public void PipeMoving(Canvas canvas, Rectangle pipeTop, Rectangle pipeBottom)
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
    }
}
