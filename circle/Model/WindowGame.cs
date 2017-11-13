namespace circle.Model
{
    public class WindowGame : Base
    {
        private int _windowWidth = 600;
        private int _windowHeight = 600;

        public int WindowHeight
        {
            get { return _windowHeight; }
            set
            {
                _windowHeight = value;
                OnPropertyChanged();
            }
        }

        public int WindowWidth
        {
            get { return _windowWidth; }
            set
            {
                _windowWidth = value;
                OnPropertyChanged();
            }
        }
    }
}