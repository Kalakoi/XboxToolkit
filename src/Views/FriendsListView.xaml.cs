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
using System.Windows.Shapes;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    /// <summary>
    /// Interaction logic for FriendsListView.xaml
    /// </summary>
    public partial class FriendsListView : Window
    {
        public FriendsListView()
        {
            InitializeComponent();
            (DataContext as FriendsListViewModel).Gamertag = XboxConnection.GetProfile().Gamertag;
            (DataContext as FriendsListViewModel).xuid = XboxConnection.GetProfile().ID.ToString();
            (DataContext as FriendsListViewModel).Friends = new List<Friend>(XboxConnection.GetFriends());
        }
        public FriendsListView(string Gamertag, string xuid)
        {
            InitializeComponent();
            (DataContext as FriendsListViewModel).Gamertag = Gamertag;
            (DataContext as FriendsListViewModel).xuid = xuid;
            (DataContext as FriendsListViewModel).Friends = new List<Friend>(XboxConnection.GetFriends(xuid));
        }
    }
}
