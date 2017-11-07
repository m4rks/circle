using System.Windows;
using circle.ViewModel;

namespace circle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Add this line:
            this.DataContext = new MovingFigurViewModel();
        }
    }
}
