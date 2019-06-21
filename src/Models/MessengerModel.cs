using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class MessengerModel : ModelBase
    {
        private List<ConversationSummary> _conversations;
        private int _selectedConversationIndex;

        public List<ConversationSummary> Conversations
        {
            get { return _conversations; }
            set { SetProperty(ref _conversations, value, nameof(Conversations)); SelectedConversationIndex = -1; }
        }
        public int SelectedConversationIndex
        {
            get { return _selectedConversationIndex; }
            set { SetProperty(ref _selectedConversationIndex, value, nameof(SelectedConversationIndex)); OnPropertyChanged(nameof(ConversationSelected)); }
        }
        public bool ConversationSelected => SelectedConversationIndex >= 0;

        private ICommand _viewConversation;
        private ICommand _refreshList;
        private ICommand _sendReply;

        public ICommand ViewConversation
        {
            get { return _viewConversation; }
            set { SetProperty(ref _viewConversation, value, nameof(ViewConversation)); }
        }
        public ICommand RefreshList
        {
            get { return _refreshList; }
            set { SetProperty(ref _refreshList, value, nameof(RefreshList)); }
        }
        public ICommand SendReply
        {
            get { return _sendReply; }
            set { SetProperty(ref _sendReply, value, nameof(SendReply)); }
        }
    }
}
