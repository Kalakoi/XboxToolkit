using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class ConversationModel : ModelBase
    {
        private string _gamertag;
        private string _xuid;
        private Conversation _conversation;

        private ICommand _refreshList;
        private ICommand _sendReply;

        public string Gamertag
        {
            get { return _gamertag; }
            set { SetProperty(ref _gamertag, value, nameof(Gamertag)); OnPropertyChanged(nameof(Title)); }
        }
        public string Title => string.Format("Conversation with {0}", Gamertag);
        public string xuid
        {
            get { return _xuid; }
            set { SetProperty(ref _xuid, value, nameof(xuid)); }
        }
        public Conversation Conversation
        {
            get { return _conversation; }
            set { SetProperty(ref _conversation, value, nameof(Conversation)); }
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
