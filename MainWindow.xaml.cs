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

namespace FlappyBirdSzeru2026_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
<<<<<<< HEAD
        private DispatcherTimer gameTimer = new DispatcherTimer();
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
            Moving moving = new Moving();
            moving.PipeMoving();
=======
        public MainWindow()
        {
            InitializeComponent();
>>>>>>> parent of a0de085 (moving pipe)
        }
    }
}