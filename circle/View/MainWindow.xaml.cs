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
        private double moveStepX = 6;  //todo:potem zmienic na 1
        private double moveStepY = 6;//todo:potem zmienic na 1
        //Function to get random number
        private static readonly Random getrandom = new Random();

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

            double fi =(double) GetRandomNumber(0, 360) / (360 + 1) * 2 * Math.PI;
            moveStepX = Math.Cos(fi);
            moveStepY = Math.Sin(fi);

            
            if (XValue + Ellipse.Width > myCanvas.ActualWidth && moveStepX > 0)     //x
            {
                moveStepX = (-1)* moveStepX;
            }
            if (XValue < 0  && moveStepX < 0)
            {
                moveStepX = +moveStepX;
            }

            if (YValue + Ellipse.Height > myCanvas.ActualHeight && moveStepY > 0)   //y
            {
                moveStepY = (-1) * moveStepY;
            }
            if (YValue < 0 && moveStepY < 0)
            {
                moveStepY = +moveStepY;
            }

            Canvas.SetLeft(Ellipse, XValue + moveStepX);  //x  = x + D1
            Canvas.SetTop(Ellipse, YValue + moveStepY);   //y  = y + D2

        }
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
