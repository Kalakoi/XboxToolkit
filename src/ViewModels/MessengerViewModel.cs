using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class MessengerViewModel : MessengerModel
    {
        public MessengerViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Conversations = new List<ConversationSummary>();
        }

        private void InitializeCommands()
        {
            RefreshList = new RelayCommand(ListRefresh);
            ViewConversation = new RelayCommand(ConversationView);
            SendReply = new RelayCommand(ReplySend);
        }

        private void ListRefresh(object obj)
        {
            Conversations = new List<ConversationSummary>(XboxConnection.GetConversations());
        }

        private void ConversationView(object obj)
        {
            ConversationView v = new ConversationView(Conversations.ElementAt(SelectedConversationIndex).SenderGamertag, Conversations.ElementAt(SelectedConversationIndex).SenderXUID.ToString());
            v.Show();
        }

        private void ReplySend(object obj)
        {
            string MessageText = string.Empty;
            MessageBoxResult res = InputBoxView.ShowDialog(string.Format("New message to {0}", Conversations.ElementAt(SelectedConversationIndex).SenderGamertag), "Message:", out MessageText, MessageBoxButton.OKCancel);
            if (res == MessageBoxResult.OK)
                XboxConnection.SendMessage(Conversations.ElementAt(SelectedConversationIndex).SenderGamertag, MessageText);
        }
    }
}
