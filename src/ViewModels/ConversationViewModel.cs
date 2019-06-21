using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class ConversationViewModel : ConversationModel
    {
        public ConversationViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Gamertag = "Xbox Live";
            xuid = "0";
            Conversation = new Conversation() { Summary = new ConversationSummary(), Messages = new List<Message>() { new Message() } };
        }

        private void InitializeCommands()
        {
            RefreshList = new RelayCommand(ListRefresh);
            SendReply = new RelayCommand(ReplySend);
        }

        private void ListRefresh(object obj)
        {
            Conversation = XboxConnection.GetConversation(xuid);
        }

        private void ReplySend(object obj)
        {
            string MessageText = string.Empty;
            MessageBoxResult res = InputBoxView.ShowDialog(string.Format("New message to {0}", Gamertag), "Message:", out MessageText, MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
                XboxConnection.SendMessage(Gamertag, MessageText);
        }
    }
}
