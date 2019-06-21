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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    /// <summary>
    /// Interaction logic for FriendSummary.xaml
    /// </summary>
    public partial class FriendSummary : UserControl
    {
        public FriendSummary()
        {
            InitializeComponent();
        }

        public Friend Friend
        {
            get { return (Friend)GetValue(FriendProperty); }
            set { SetValue(FriendProperty, value); }
        }

        public static DependencyProperty FriendProperty =
            DependencyProperty.Register(nameof(Friend), typeof(Friend), typeof(FriendSummary));

        /*
        public Uri ProfilePicture
        {
            get { return (Uri)GetValue(ProfilePictureProperty); }
            set { SetValue(ProfilePictureProperty, value); }
        }

        public string Gamertag
        {
            get { return (string)GetValue(GamertagProperty); }
            set { SetValue(GamertagProperty, value); }
        }

        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }

        public string Presence
        {
            get { return (string)GetValue(PresenceProperty); }
            set { SetValue(PresenceProperty, value); }
        }

        public static DependencyProperty ProfilePictureProperty =
            DependencyProperty.Register(nameof(ProfilePicture), typeof(Uri), typeof(FriendSummary));

        public static DependencyProperty GamertagProperty =
            DependencyProperty.Register(nameof(Gamertag), typeof(string), typeof(FriendSummary));

        public static DependencyProperty StatusProperty =
            DependencyProperty.Register(nameof(Status), typeof(string), typeof(FriendSummary));

        public static DependencyProperty PresenceProperty =
            DependencyProperty.Register(nameof(Presence), typeof(string), typeof(FriendSummary));
        */
    }
}
