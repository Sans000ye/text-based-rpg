using Engine.ViewModels;
using System.Windows;

namespace soscrpg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession gs;
        public MainWindow()
        {
            InitializeComponent();
            gs = new GameSession();
            DataContext = gs;
        }


    }
}