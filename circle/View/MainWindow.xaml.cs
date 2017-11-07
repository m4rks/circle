using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace circle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double moveStepX = 6;
        private double moveStepY = 6;
        public MainWindow()
        {
            InitializeComponent();
            InitAnimation();
        }
        Double YValue
        {
            get
            {
                bool isNaN = Double.IsNaN(Canvas.GetTop(Ellipse));
                return isNaN ? 0 : Canvas.GetTop(Ellipse);
            }
        }
        Double XValue
        {
            get
            {
                bool isNaN = Double.IsNaN(Canvas.GetLeft(Ellipse));
                return isNaN ? 0 : Canvas.GetLeft(Ellipse);
            }
        }
        private void InitAnimation()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            //timer.Tick += timer_Tick;
            timer.Tick += new EventHandler(someEventHandler);

            timer.Start();
        }
        private void someEventHandler(Object sender, EventArgs args)
        {
            Canvas.SetLeft(Ellipse, XValue + moveStepX);
            Canvas.SetTop(Ellipse, YValue + moveStepY);

            if (YValue + Ellipse.Height > myCanvas.ActualHeight && moveStepY > 0)
            {
                moveStepY = -6.0;
            }
            if (YValue < 0 && moveStepY < 0)
            {
                moveStepY = +6.0;
            }
            if (XValue + Ellipse.Width > myCanvas.ActualWidth && moveStepX > 0)
            {
                moveStepX = -6.0;
            }
            if (XValue < 0  && moveStepX < 0)
            {
                moveStepX = +6.0;
            }
        }
    }
}
