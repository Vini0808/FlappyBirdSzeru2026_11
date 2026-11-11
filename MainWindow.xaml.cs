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
using System.Windows.Threading;

namespace FlappyBirdSzeru2026_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private double pipeSpeed = 5;
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            gameTimer.Interval = TimeSpan.FromMilliseconds(16);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            double x  = Canvas.GetLeft(PipeTop) - pipeSpeed;

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