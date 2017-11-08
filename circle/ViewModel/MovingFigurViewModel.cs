using circle.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace circle.ViewModel
{
    class MovingFigurViewModel
    {
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
            FigureList = new ObservableCollection<Figure>();
            _myFigure = new Figure { Id = 0, StepX = 20, StepY = 20, TypeFigure = new Ellipse(), X = 20, Y = 20 };
            AddFigure(_myFigure);
            InitAnimation();
        }

        private void AddFigure(Figure myFigure)
        {
            // 3 at most, please!
            if (FigureList.Count == 9)
            {
                return;
                FigureList.RemoveAt(0);
            }
            FigureList.Add(myFigure);
        }
        public ObservableCollection<Figure> FigureList { get; private set; }

        private void InitAnimation()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            //timer.Tick += timer_Tick;
            timer.Tick += new EventHandler(someEventHandler);
            timer.Start();
        }

        private void someEventHandler(object sender, EventArgs e)
        {
            Random random = new Random();
            _myFigure = new Figure { Id = 1, StepX = 5, StepY = 5, TypeFigure = new Ellipse(), X = random.Next(0, 500), Y = random.Next(0, 500) };
            AddFigure(_myFigure);
            MoveFigure(FigureList);
        }

        private void MoveFigure(ObservableCollection<Figure> figureList)
        {
            figureList.Select(c =>
            {
                c.X += c.StepX;
                return c;
            }).ToList();
            figureList.Select(c =>
            {
                c.Y += c.StepY;
                return c;
            }).ToList();

            figureList.Where(c => c.X + 20 > 600 || c.X < 0).Select(c =>
            {
                c.StepX = c.StepX * (-1);
                return c;
            }).ToList();
            figureList.Where(c => c.Y + 20 > 600 || c.Y < 0).Select(c =>
            {
                c.StepY = c.StepY * (-1);
                return c;
            }).ToList();
        }
    }
}
