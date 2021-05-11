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
        public List<Game> filteredGames;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //takes data from database ands them too AllGames
            GameData db = new GameData();

            var query = from g in db.Games
                        select g;

            AllGames = query.ToList();

            lbxGames.ItemsSource = AllGames;

           /* chbPC.IsChecked = true;
            chbXbox.IsChecked = true;
            chbPS.IsChecked = true;
            chbSwitch.IsChecked = true;*/
        }

        private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //when a game selected in left listbox it displays score and price
            Game selectedGame = lbxGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                //Amended for Q8 
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                  
                
                tblkGameDetails.Text = $"{selectedGame.Price:C}";
            }

        }
        
        //was too filter but ran out of time and it would cause errors to run without it working 

       /* private void Chbx_Click(object sender, RoutedEventArgs e)
        {

            //all games
            if ((chbPC.IsChecked == true) && (chbXbox.IsChecked == true) && (chbPS.IsChecked == true) && (chbSwitch.IsChecked == true))
                UpdateListBox(AllGames);

            //no games
            else if ((chbPC.IsChecked == false) && (chbXbox.IsChecked == false) && (chbPS.IsChecked == false) && (chbSwitch.IsChecked == false))
                lbxGames.ItemsSource = null;

            //PC
            else if ((chbPC.IsChecked == true) && (chbXbox.IsChecked == false) && (chbPS.IsChecked == false) && (chbSwitch.IsChecked == false))
            {
                AllGames.Clear();

                for (int i = 0; i < AllGames.Count; i++)
                {
                    if (AllGames[i].Platform.Contains("PC"))
                        lbxGames.ItemsSource = AllGames[i].ToString();
                }

                UpdateListBox(filteredGames);
            }

            // xbox
            else if ((chbPC.IsChecked == false) && (chbXbox.IsChecked == true) && (chbPS.IsChecked == false) && (chbSwitch.IsChecked == false))
            {
                filteredGames.Clear();

                for (int i = 0; i < AllGames.Count; i++)
                {
                    if (AllGames[i].Platform.Contains("Xbox"))
                        lbxGames.ItemsSource = AllGames[i].ToString();
                }
                UpdateListBox(filteredGames);
            }

          
                //PS
            else if ((chbPC.IsChecked == false) && (chbXbox.IsChecked == false) && (chbPS.IsChecked == true) && (chbSwitch.IsChecked == false))
                {
                    filteredGames.Clear();

                    for (int i = 0; i < AllGames.Count; i++)
                    {
                        if (AllGames[i].Platform.Contains("PS"))
                            lbxGames.ItemsSource = AllGames[i].ToString();
                    }

                    UpdateListBox(filteredGames);
                }

                //switch
                else if ((chbPC.IsChecked == false) && (chbXbox.IsChecked == false) && (chbPS.IsChecked == false) && (chbSwitch.IsChecked == true))
                {
                    filteredGames.Clear();

                    for (int i = 0; i < AllGames.Count; i++)
                    {
                        if (AllGames[i].Platform.Contains("Switch"))
                            lbxGames.ItemsSource = AllGames[i].ToString();
                    }

                    UpdateListBox(filteredGames);

                }

            }

            private void UpdateListBox(List<Game> AllGames)
            {


                //Refreshes the display
                lbxGames.ItemsSource = null;
                lbxGames.ItemsSource = AllGames;

            }*/

        }
    }

    
