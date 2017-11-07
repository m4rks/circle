using System.Windows.Shapes;

namespace circle.Model
{
    public class Figure : Base
    {

        public int Id { get; set; }
        public Shape TypeFigure { get; set; }
        public double stepX { get; set; }
        public double stepY { get; set; }

    }
}
