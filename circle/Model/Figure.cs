﻿using System.Windows.Shapes;

namespace circle.Model
{
    public class Figure : Point
    {
        private double _stepY;
        private double _stepX;

        public int Id { get; set; }
        public Shape TypeFigure { get; set; }

        public double StepX
        {
            get { return _stepX; }
            set { _stepX = value; OnPropertyChanged(); }
        }

        public double StepY
        {
            get { return _stepY; }
            set { _stepY = value; OnPropertyChanged(); }
        }

        public string Image { get; internal set; }
    }
}
