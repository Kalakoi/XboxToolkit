using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class MassMessageModel : ModelBase
    {
        private List<Friend> _friends;
        private int _friendIndex;
        private List<Friend> _selectedFriends;
        private int _selectedFriendIndex;
        private string _message;
        private bool _individualMessages;

        private ICommand _addSelected;
        private ICommand _addAll;
        private ICommand _removeSelected;
        private ICommand _removeAll;
        private ICommand _sendMessage;
        
        public List<Friend> Friends
        {
            get { return _friends; }
            set { SetProperty(ref _friends, value, nameof(Friends)); FriendIndex = -1; }
        }
        public int FriendIndex
        {
            get { return _friendIndex; }
            set { SetProperty(ref _friendIndex, value, nameof(FriendIndex)); }
        }
        public List<Friend> SelectedFriends
        {
            get { return _selectedFriends; }
            set { SetProperty(ref _selectedFriends, value, nameof(SelectedFriends)); }
        }
        public int SelectedFriendIndex
        {
            get { return _selectedFriendIndex; }
            set { SetProperty(ref _selectedFriendIndex, value, nameof(SelectedFriendIndex)); }
        }
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value, nameof(Message)); }
        }
        public bool IndividualMessages
        {
            get { return _individualMessages; }
            set { SetProperty(ref _individualMessages, value, nameof(IndividualMessages)); }
        }

        public ICommand AddSelected
        {
            get { return _addSelected; }
            set { SetProperty(ref _addSelected, value, nameof(AddSelected)); }
        }
        public ICommand AddAll
        {
            get { return _addAll; }
            set { SetProperty(ref _addAll, value, nameof(AddAll)); }
        }
        public ICommand RemoveSelected
        {
            get { return _removeSelected; }
            set { SetProperty(ref _removeSelected, value, nameof(RemoveSelected)); }
        }
        public ICommand RemoveAll
        {
            get { return _removeAll; }
            set { SetProperty(ref _removeAll, value, nameof(RemoveAll)); }
        }
        public ICommand SendMessage
        {
            get { return _sendMessage; }
            set { SetProperty(ref _sendMessage, value, nameof(SendMessage)); }
        }
    }
}
