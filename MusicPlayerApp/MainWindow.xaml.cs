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

namespace MusicPlayerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MouseLeftButtonDown += (s, e) =>
            {
                this.DragMove();
            };

            List<Sidebar> sidebarBrowseMusicList = new List<Sidebar>();
            sidebarBrowseMusicList.Add(new Sidebar() { Icon = "./Images/explore.png", Title = "Explore" });
            sidebarBrowseMusicList.Add(new Sidebar() { Icon = "./Images/hear_this.png", Title = "Hear this" });
            sidebarBrowseMusicList.Add(new Sidebar() { Icon = "./Images/radio.png", Title = "Radio" });
            icBrowseMusicSidebar.ItemsSource = sidebarBrowseMusicList;

            List<Sidebar> sidebarYourLibraryList = new List<Sidebar>();
            sidebarYourLibraryList.Add(new Sidebar() { Icon = "./Images/last_added.png", Title = "Last added songs" });
            sidebarYourLibraryList.Add(new Sidebar() { Icon = "./Images/favorite_songs.png", Title = "Favorites" });
            sidebarYourLibraryList.Add(new Sidebar() { Icon = "./Images/artists.png", Title = "Artists" });
            sidebarYourLibraryList.Add(new Sidebar() { Icon = "./Images/songs.png", Title = "Songs" });
            sidebarYourLibraryList.Add(new Sidebar() { Icon = "./Images/genres.png", Title = "Genres" });
            icYourLibrarySidebar.ItemsSource = sidebarYourLibraryList;
            
            List<Sidebar> sidebarPlaylistsList = new List<Sidebar>();
            sidebarPlaylistsList.Add(new Sidebar() { Icon = "./Images/playlist.png", Title = "Firday mood" });
            sidebarPlaylistsList.Add(new Sidebar() { Icon = "./Images/playlist.png", Title = "Work hard" });
            sidebarPlaylistsList.Add(new Sidebar() { Icon = "./Images/playlist.png", Title = "Back to childhood" });
            sidebarPlaylistsList.Add(new Sidebar() { Icon = "./Images/playlist.png", Title = "Rainy mood" });
            sidebarPlaylistsList.Add(new Sidebar() { Icon = "./Images/playlist.png", Title = "My Top-100" });
            icPlaylistsSidebar.ItemsSource = sidebarPlaylistsList;
        }
    }

    public class Sidebar
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }

    }
}
