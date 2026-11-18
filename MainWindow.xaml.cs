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
using System.Drawing;
using System.Windows.Threading;

namespace FlappyBirdSzeru2026_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer gameTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            //gameTimer.Interval = TimeSpan.FromMilliseconds(16);
            //gameTimer.Tick += GameLoop;
            //gameTimer.Start();
            CompositionTarget.Rendering += GameLoop;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            Moving moving = new Moving();
            moving.PipeMoving(GameCanvas, PipeTop, PipeBottom);
            moving.BirdMovingUp(GameCanvas, Bird, 3);
            moving.BirdMovingAround(GameCanvas, Bird);
            moving.IsColliding(Bird, PipeTop, PipeBottom);
        }
    }
}