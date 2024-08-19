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
        private void Exp_gain (object sender, RoutedEventArgs e)
        {
            gs.CurrentPlayer.EXP = gs.CurrentPlayer.EXP + 10;
        }

    }
}