using circle.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace circle.ViewModel
{
    class ButtonStartCommand
    {
        private decimal amount;

        public ButtonStartCommand(decimal amount)
        {
            this.amount = amount;
        }

        public void Execute()
        {
            Console.WriteLine($"Calculated {amount}");

        }
    }
    class MovingFigurViewModel
    {
        #region FIELDS
        private Figure _myFigure;
        public WindowGame WindowGame { get; set; }
        public ObservableCollection<Figure> FigureList { get; private set; }
        #endregion

        public MovingFigurViewModel()
        {
            WindowGame = new WindowGame { WindowHeight = 600, WindowWidth = 800 };
            FigureList = new ObservableCollection<Figure>();
            InitAnimation();
        }

        private void AddFigure(Figure myFigure)
        {
            Random random = new Random();
            if (FigureList.Count > 12 && random.Next(0, 100) > 4)
            {
                FigureList.RemoveAt(0);
            }
            FigureList.Add(myFigure);
        }

        private void InitAnimation()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(65);
            //timer.Tick += timer_Tick;
            timer.Tick += new EventHandler(someEventHandler);
            timer.Start();
        }

        private void someEventHandler(object sender, EventArgs e)
        {
            List<string> listImage = new List<string> { "../Resources/red_ballon.png", "../Resources/blue_ballon.png", "../Resources/orange_ballon.png", "../Resources/ImageVWpng.png" };
            Random random = new Random();
            _myFigure = new Figure
            {
                Id = FigureList.Count + 1,
                StepX = random.Next(-10, 10),
                StepY = random.Next(-10, 10),
                TypeFigure = new Rectangle(),
                X = random.Next(0, WindowGame.WindowWidth),
                Y = random.Next(0, WindowGame.WindowHeight),
                Image = listImage[random.Next(0, listImage.Count)],

            };
            AddFigure(_myFigure);
            MoveFigure(FigureList);
        }

        private void MoveFigure(ObservableCollection<Figure> figureList)
        {
            figureList.Select(c =>
            {
                c.X = c.X + c.StepX;
                return c;
            }).ToList();
            figureList.Select(c =>
            {
                c.Y = c.Y + c.StepY;
                return c;
            }).ToList();
            //todo: jak sie dostac do tych 20 i 600
            figureList.Where(c => c.X + 60 > WindowGame.WindowWidth || c.X < 0).Select(c =>
            {
                c.StepX = c.StepX * (-1);
                return c;
            }).ToList();
            figureList.Where(c => c.Y + 60 > WindowGame.WindowHeight || c.Y < 0).Select(c =>
            {
                c.StepY = c.StepY * (-1);
                return c;
            }).ToList();
        }
    }
}
