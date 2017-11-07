using circle.Model;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace circle.ViewModel
{
    class MovingFigurViewModel
    {

        private double moveStepX = 6;
        private double moveStepY = 6;
        private Figure _myFigure;
        public Figure MyFigure
        {
            get
            {
                return _myFigure;
            }
            set
            {
                _myFigure = value;
            }
        }

        public MovingFigurViewModel()
        {
            PointList = new ObservableCollection<Point>();

            // Some example data:
            AddPoint(new Point(10, 10));
            AddPoint(new Point(200, 200));
            AddPoint(new Point(500, 500));
            //_myFigure = new circle.Model.Figure
            //{
            //    Id = 0,
            //    StepX = 20,
            //    StepY = 20,
            //    TypeFigure = new Ellipse(),
            //    XPosition = 20,
            //    YPosition = 20
            //};
        }
        public ObservableCollection<Point> PointList { get; private set; }
        public void AddPoint(Point p)
        {
            //// 3 at most, please!
            //if (PointList.Count == 3)
            //{
            //    PointList.RemoveAt(0);
            //}
            PointList.Add(p);
        }


        private void InitAnimation()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            //timer.Tick += timer_Tick;
            timer.Tick += new EventHandler(someEventHandler);
            timer.Start();
        }

        private void someEventHandler(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Double XValue
        //{
        //    get
        //    {
        //        bool isNaN = Double.IsNaN(Canvas.GetLeft(Ellipse));
        //        return isNaN ? 0 : Canvas.GetLeft(Ellipse);
        //    }
        //}

        //Double YValue
        //{
        //    get
        //    {
        //        bool isNaN = Double.IsNaN(Canvas.GetTop(Ellipse));
        //        return isNaN ? 0 : Canvas.GetTop(Ellipse);
        //    }
        //}

        //private void someEventHandler()
        //{
        //    Canvas.SetLeft(Ellipse, XValue + moveStepX);
        //    Canvas.SetTop(Ellipse, YValue + moveStepY);

        //    if (YValue + Ellipse.Height > myCanvas.ActualHeight && moveStepY > 0)
        //    {
        //        moveStepY = -6.0;
        //    }
        //    if (YValue < 0 && moveStepY < 0)
        //    {
        //        moveStepY = +6.0;
        //    }
        //    if (XValue + Ellipse.Width > myCanvas.ActualWidth && moveStepX > 0)
        //    {
        //        moveStepX = -6.0;
        //    }
        //    if (XValue < 0 && moveStepX < 0)
        //    {
        //        moveStepX = +6.0;
        //    }
        //}
    }
}
