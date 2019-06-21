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
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    /// <summary>
    /// Interaction logic for ConversationView.xaml
    /// </summary>
    public partial class ConversationView : Window
    {
        public ConversationView()
        {
            InitializeComponent();
        }

        public ConversationView(string Gamertag, string xuid)
        {
            InitializeComponent();
            (DataContext as ConversationViewModel).Gamertag = Gamertag;
            (DataContext as ConversationViewModel).xuid = xuid;
            (DataContext as ConversationViewModel).Conversation = XboxConnection.GetConversation(xuid);
        }
    }
}
