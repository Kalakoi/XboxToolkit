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
    /// Interaction logic for ProfileViewerView.xaml
    /// </summary>
    public partial class ProfileViewerView : Window
    {
        public ProfileViewerView()
        {
            InitializeComponent();
            (DataContext as ProfileViewerViewModel).Profile = XboxConnection.GetProfile();
        }
        public ProfileViewerView(XboxProfile Profile)
        {
            InitializeComponent();
            (DataContext as ProfileViewerViewModel).Profile = Profile;
        }
        public ProfileViewerView(string Gamertag)
        {
            InitializeComponent();
            (DataContext as ProfileViewerViewModel).Profile = XboxConnection.GetProfile(Gamertag);
        }
    }
}
