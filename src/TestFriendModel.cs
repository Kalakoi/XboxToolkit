using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class TestFriendModel : ModelBase
    {
        private List<Friend> _friendsList;
        private int _selectedFriendIndex;

        public List<Friend> FriendsList
        {
            get { return _friendsList; }
            set { SetProperty(ref _friendsList, value, nameof(FriendsList)); SelectedFriendIndex = -1; }
        }
        public int SelectedFriendIndex
        {
            get { return _selectedFriendIndex; }
            set { SetProperty(ref _selectedFriendIndex, value, nameof(SelectedFriendIndex)); }
        }
    }
}
