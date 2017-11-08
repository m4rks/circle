namespace circle.Model
{
    public abstract class Point : Base
    {
        private double _xPosition;
        private double _yPosition;

        public double X
        {
            get { return _xPosition; }
            set
            {
                _xPosition = value;
                OnPropertyChanged();
            }
        }

        public double Y
        {
            get { return _yPosition; }
            set
            {
                _yPosition = value;
                OnPropertyChanged();
            }
        }


    }
}
