using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kalakoi.Xbox.App
{
    public abstract class InputBoxModel : ModelBase
    {
        private string _title;
        private string _prompt;
        private string _input;
        private MessageBoxButton _buttons;
        private MessageBoxResult _result;

        private ICommand _ok;
        private ICommand _cancel;
        private ICommand _yes;
        private ICommand _no;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value, nameof(Title)); }
        }
        public string Prompt
        {
            get { return _prompt; }
            set { SetProperty(ref _prompt, value, nameof(Prompt)); }
        }
        public string Input
        {
            get { return _input; }
            set { SetProperty(ref _input, value, nameof(Input)); }
        }
        public MessageBoxButton Buttons
        {
            get { return _buttons; }
            set
            {
                SetProperty(ref _buttons, value, nameof(Buttons));
                OnPropertyChanged(nameof(OKVisible));
                OnPropertyChanged(nameof(CancelVisible));
                OnPropertyChanged(nameof(YesNoVisible));
            }
        }
        public MessageBoxResult Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value, nameof(Result)); }
        }
        public Visibility OKVisible => 
            Buttons == MessageBoxButton.OK || Buttons == MessageBoxButton.OKCancel ? 
            Visibility.Visible : 
            Visibility.Collapsed;
        public Visibility CancelVisible =>
            Buttons == MessageBoxButton.OKCancel || Buttons == MessageBoxButton.YesNoCancel ?
            Visibility.Visible :
            Visibility.Collapsed;
        public Visibility YesNoVisible =>
            Buttons == MessageBoxButton.YesNo || Buttons == MessageBoxButton.YesNoCancel ?
            Visibility.Visible :
            Visibility.Collapsed;

        public ICommand OK
        {
            get { return _ok; }
            set { SetProperty(ref _ok, value, nameof(OK)); }
        }
        public ICommand Cancel
        {
            get { return _cancel; }
            set { SetProperty(ref _cancel, value, nameof(Cancel)); }
        }
        public ICommand Yes
        {
            get { return _yes; }
            set { SetProperty(ref _yes, value, nameof(Yes)); }
        }
        public ICommand No
        {
            get { return _no; }
            set { SetProperty(ref _no, value, nameof(No)); }
        }
    }
}
