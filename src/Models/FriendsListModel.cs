using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class FriendsListModel : ModelBase
    {
        private string _gamertag;
        private string _xuid;
        private List<Friend> _friends;
        private int _selectedFriendIndex;

        public string Gamertag
        {
            get { return _gamertag; }
            set { SetProperty(ref _gamertag, value, nameof(Gamertag)); OnPropertyChanged(nameof(Title)); }
        }
        public string Title => string.Format("{0}'s Friends List", Gamertag);
        public string xuid
        {
            get { return _xuid; }
            set { SetProperty(ref _xuid, value, nameof(xuid)); }
        }
        public List<Friend> Friends
        {
            get { return _friends; }
            set { SetProperty(ref _friends, value, nameof(Friends)); SelectedFriendIndex = -1; }
        }
        public int SelectedFriendIndex
        {
            get { return _selectedFriendIndex; }
            set { SetProperty(ref _selectedFriendIndex, value, nameof(SelectedFriendIndex)); OnPropertyChanged(nameof(FriendSelected)); }
        }
        public bool FriendSelected => SelectedFriendIndex >= 0;

        private ICommand _addFriend;
        private ICommand _removeFriend;
        private ICommand _favoriteFriend;
        private ICommand _unfavoriteFriend;
        private ICommand _viewProfile;
        private ICommand _viewFriends;
        private ICommand _refreshList;
        private ICommand _sendMessage;

        public ICommand AddFriend
        {
            get { return _addFriend; }
            set { SetProperty(ref _addFriend, value, nameof(AddFriend)); }
        }
        public ICommand RemoveFriend
        {
            get { return _removeFriend; }
            set { SetProperty(ref _removeFriend, value, nameof(RemoveFriend)); }
        }
        public ICommand FavoriteFriend
        {
            get { return _favoriteFriend; }
            set { SetProperty(ref _favoriteFriend, value, nameof(FavoriteFriend)); }
        }
        public ICommand UnfavoriteFriend
        {
            get { return _unfavoriteFriend; }
            set { SetProperty(ref _unfavoriteFriend, value, nameof(UnfavoriteFriend)); }
        }
        public ICommand ViewProfile
        {
            get { return _viewProfile; }
            set { SetProperty(ref _viewProfile, value, nameof(ViewProfile)); }
        }
        public ICommand ViewFriends
        {
            get { return _viewFriends; }
            set { SetProperty(ref _viewFriends, value, nameof(ViewFriends)); }
        }
        public ICommand RefreshList
        {
            get { return _refreshList; }
            set { SetProperty(ref _refreshList, value, nameof(RefreshList)); }
        }
        public ICommand SendMessage
        {
            get { return _sendMessage; }
            set { SetProperty(ref _sendMessage, value, nameof(SendMessage)); }
        }
    }
}
