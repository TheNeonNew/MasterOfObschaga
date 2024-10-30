using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterOfObschaga
{
    public partial class MainWindow : Window
    {
        private double playerX = 180;
        private double playerY = 180;

        public MainWindow()
        {
            InitializeComponent();
            UpdatePlayerPosition();
        }

        private void ExitGame(object sender, RoutedEventArgs e) { System.Environment.Exit(1); }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    if (playerY > 0) playerY -= 10;
                    break;
                case Key.S:
                    if (playerY < GameCanvas.ActualHeight - 20) playerY += 10;
                    break;
                case Key.A:
                    if (playerX > 0) playerX -= 10;
                    break;
                case Key.D:
                    if (playerX < GameCanvas.ActualWidth - 20) playerX += 10;
                    break;
            }
            UpdatePlayerPosition();
        }

        private void UpdatePlayerPosition()
        {
            Canvas.SetLeft(PlayerUnit, playerX);
            Canvas.SetTop(PlayerUnit, playerY);
        }
    }
}