using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kalakoi.Xbox.App
{
    /// <summary>
    /// Interaction logic for InputBoxView.xaml
    /// </summary>
    public partial class InputBoxView : Window
    {
        public InputBoxView()
        {
            InitializeComponent();
        }

        public static MessageBoxResult ShowDialog(string Title, string Prompt, out string Input, MessageBoxButton Buttons = MessageBoxButton.OK)
        {
            InputBoxView v = new InputBoxView();
            (v.DataContext as InputBoxViewModel).SetBox(Title, Prompt, Buttons);
            v.ShowDialog();
            Input = (v.DataContext as InputBoxViewModel).Input;
            return (v.DataContext as InputBoxViewModel).Result;
        }
    }
}
