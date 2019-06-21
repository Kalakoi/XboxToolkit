using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class TestFriendViewModel : TestFriendModel
    {
        public TestFriendViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            FriendsList = new List<Friend>(XboxConnection.GetFriends());
        }

        private void InitializeCommands()
        {

        }
    }
}
