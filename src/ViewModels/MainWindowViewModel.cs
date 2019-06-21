using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class MainWindowViewModel : MainWindowModel
    {
        public MainWindowViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Response = string.Empty;
        }

        private void InitializeCommands()
        {
            ViewProfile = new RelayCommand(ProfileView);
            ViewFriends = new RelayCommand(FriendsView);
            ViewMessages = new RelayCommand(MessagesView);
            ViewMassMessage = new RelayCommand(MassMessageView);
            Command = new RelayCommand(DoCommand);
        }

        private void DoCommand(object obj)
        {
            //Response = XboxConnection.GetClips();
            TestFriendView v = new TestFriendView();
            v.Show();
        }

        private void ProfileView(object obj)
        {
            ProfileViewerView v = new ProfileViewerView();
            v.Show();
        }

        private void FriendsView(object obj)
        {
            FriendsListView v = new FriendsListView();
            v.Show();
        }

        private void MessagesView(object obj)
        {
            MessengerView v = new MessengerView();
            v.Show();
        }

        private void MassMessageView(object obj)
        {
            MassMessageView v = new MassMessageView();
            v.Show();
        }
    }
}
