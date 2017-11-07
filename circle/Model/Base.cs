namespace circle.Model
{
    public abstract class Base
    {
        private double _xPosition;
        private double _yPosition;

        public double XPosition
        {
            get { return _xPosition; }
            set { _xPosition = value; }
        }

        public double YPosition
        {
            get { return _yPosition; }
            set { _yPosition = value; }
        }
    }
}
