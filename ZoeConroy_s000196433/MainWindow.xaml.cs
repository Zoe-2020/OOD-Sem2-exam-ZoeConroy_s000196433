using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZoeConroy_s000196433
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> AllGames;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GameData db = new GameData();

            var query = from g in db.Games
                        select g;

            AllGames = query.ToList();

            lbxGames.ItemsSource = AllGames;
        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbxGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tblkGameDetails.Text = $"{selectedGame.Price:C}";
            }

        }

    }
}
