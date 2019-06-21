using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class MassMessageViewModel : MassMessageModel
    {
        public MassMessageViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Friends = new List<Friend>(XboxConnection.GetFriends().OrderBy(b => b.Gamertag));
            SelectedFriends = new List<Friend>();
            Message = string.Empty;
            IndividualMessages = true;
        }

        private void InitializeCommands()
        {
            AddSelected = new RelayCommand(SelectedAdd);
            AddAll = new RelayCommand(AllAdd);
            RemoveSelected = new RelayCommand(SelectedRemove);
            RemoveAll = new RelayCommand(AllRemove);
            SendMessage = new RelayCommand(MessageSend);
        }

        private void MessageSend(object obj)
        {
            if (IndividualMessages)
            {
                foreach (Friend f in SelectedFriends)
                {
                    XboxConnection.SendMessage(f.Gamertag, Message);
                }
                MessageBox.Show(string.Format("Message sent to {0} friends.", SelectedFriends.Count), "Success", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void SelectedAdd(object obj)
        {
            List<Friend> LeftTemp = new List<Friend>(Friends);
            List<Friend> RightTemp = new List<Friend>(SelectedFriends);
            RightTemp.Add(LeftTemp.ElementAt(FriendIndex));
            LeftTemp.RemoveAt(FriendIndex);
            Friends = LeftTemp;
            SelectedFriends = RightTemp;
        }

        private void AllAdd(object obj)
        {
            List<Friend> RightTemp = new List<Friend>(SelectedFriends);
            foreach (Friend f in Friends)
                RightTemp.Add(f);
            SelectedFriends = RightTemp;
            Friends = new List<Friend>();
        }

        private void SelectedRemove(object obj)
        {
            List<Friend> LeftTemp = new List<Friend>(Friends);
            List<Friend> RightTemp = new List<Friend>(SelectedFriends);
            LeftTemp.Add(RightTemp.ElementAt(SelectedFriendIndex));
            RightTemp.RemoveAt(SelectedFriendIndex);
            Friends = LeftTemp;
            SelectedFriends = RightTemp;
        }

        private void AllRemove(object obj)
        {
            List<Friend> LeftTemp = new List<Friend>(Friends);
            foreach (Friend f in SelectedFriends)
                LeftTemp.Add(f);
            SelectedFriends = new List<Friend>();
            Friends = LeftTemp;
        }
    }
}
