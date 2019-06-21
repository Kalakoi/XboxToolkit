using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kalakoi.Xbox.App
{
    public abstract class MainWindowModel : ModelBase
    {
        private string _response;

        private ICommand _viewProfile;
        private ICommand _viewFriends;
        private ICommand _viewMessages;
        private ICommand _viewMassMessage;
        private ICommand _command;

        public string Response
        {
            get { return _response; }
            set { SetProperty(ref _response, value, nameof(Response)); }
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
        public ICommand ViewMessages
        {
            get { return _viewMessages; }
            set { SetProperty(ref _viewMessages, value, nameof(ViewMessages)); }
        }
        public ICommand ViewMassMessage
        {
            get { return _viewMassMessage; }
            set { SetProperty(ref _viewMassMessage, value, nameof(ViewMassMessage)); }
        }
        public ICommand Command
        {
            get { return _command; }
            set { SetProperty(ref _command, value, nameof(Command)); }
        }
    }
}
