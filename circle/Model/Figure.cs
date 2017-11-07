using System.Windows.Shapes;

namespace circle.Model
{
    public class Figure : Base
    {
        private double _stepY;
        private double _stepX;

        public int Id { get; set; }
        public Shape TypeFigure { get; set; }

        public double StepX
        {
            get { return _stepX; }
            set { _stepX = value; }
        }

        public double StepY
        {
            get { return _stepY; }
            set { _stepY = value; }
        }

    }
}
