using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class FriendsListViewModel : FriendsListModel
    {
        public FriendsListViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Gamertag = string.Empty;
            xuid = string.Empty;
            Friends = new List<Friend>();
        }

        private void InitializeCommands()
        {
            RefreshList = new RelayCommand(ListRefresh);
            ViewProfile = new RelayCommand(ProfileView);
            ViewFriends = new RelayCommand(FriendsView);
            RemoveFriend = new RelayCommand(FriendRemove);
            AddFriend = new RelayCommand(FriendAdd);
            FavoriteFriend = new RelayCommand(FriendFavorite);
            UnfavoriteFriend = new RelayCommand(FriendUnfavorite);
            SendMessage = new RelayCommand(MessageSend);
        }

        private void ListRefresh(object obj)
        {
            Friends = new List<Friend>(XboxConnection.GetFriends(xuid));
        }

        private void ProfileView(object obj)
        {
            XboxProfile Profile = XboxConnection.GetProfile(Friends.ElementAt(SelectedFriendIndex).Gamertag);
            ProfileViewerView v = new ProfileViewerView(Profile);
            v.Show();
        }

        private void FriendsView(object obj)
        {
            FriendsListView v = new FriendsListView(Friends.ElementAt(SelectedFriendIndex).Gamertag, Friends.ElementAt(SelectedFriendIndex).xuid);
            v.Show();
        }

        private void FriendRemove(object obj)
        {
            XboxConnection.RemoveFriend(Friends.ElementAt(SelectedFriendIndex).xuid);
        }

        private void FriendAdd(object obj)
        {
            string Gamertag = string.Empty;
            MessageBoxResult res = InputBoxView.ShowDialog("Send Friend Request", "Gamertag to Add:", out Gamertag, MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
                XboxConnection.AddFriend(XboxConnection.XuidFromGamertag(Gamertag));
        }

        private void FriendFavorite(object obj)
        {
            XboxConnection.FavoriteFriend(Friends.ElementAt(SelectedFriendIndex).xuid);
        }

        private void FriendUnfavorite(object obj)
        {
            XboxConnection.UnfavoriteFriend(Friends.ElementAt(SelectedFriendIndex).xuid);
        }

        private void MessageSend(object obj)
        {
            string MessageText = string.Empty;
            MessageBoxResult res = InputBoxView.ShowDialog(string.Format("New message to {0}", Friends.ElementAt(SelectedFriendIndex).Gamertag), "Message:", out MessageText, MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
                XboxConnection.SendMessage(Friends.ElementAt(SelectedFriendIndex).Gamertag, MessageText);
        }
    }
}
