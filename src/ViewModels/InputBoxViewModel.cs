using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kalakoi.Xbox.App
{
    public class InputBoxViewModel : InputBoxModel
    {
        public InputBoxViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Title = string.Empty;
            Prompt = string.Empty;
            Input = string.Empty;
            Buttons = MessageBoxButton.OK;
            Result = MessageBoxResult.None;
        }

        private void InitializeCommands()
        {
            OK = new RelayCommand(OKClick);
            Cancel = new RelayCommand(CancelClick);
            Yes = new RelayCommand(YesClick);
            No = new RelayCommand(NoClick);
        }

        private void OKClick(object obj)
        {
            Result = MessageBoxResult.OK;
            Application.Current.Windows.OfType<InputBoxView>().First().Close();
        }

        private void CancelClick(object obj)
        {
            Result = MessageBoxResult.Cancel;
            Application.Current.Windows.OfType<InputBoxView>().First().Close();
        }

        private void YesClick(object obj)
        {
            Result = MessageBoxResult.Yes;
            Application.Current.Windows.OfType<InputBoxView>().First().Close();
        }

        private void NoClick(object obj)
        {
            Result = MessageBoxResult.No;
            Application.Current.Windows.OfType<InputBoxView>().First().Close();
        }

        public void SetBox(string Title, string Prompt, MessageBoxButton Buttons)
        {
            this.Title = Title;
            this.Prompt = Prompt;
            this.Buttons = Buttons;
            Input = string.Empty;
        }
    }
}
