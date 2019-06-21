using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public abstract class ProfileViewerModel : ModelBase
    {
        private XboxProfile _profile;

        private Uri _profilePicture;
        private string _gamertag;
        private int _gamerscore;
        private string _bio;
        private string _location;
        private string _tier;
        private string _reputation;
        private string _realName;
        private Brush _primary;
        private Brush _secondary;
        private Brush _tertiary;

        public XboxProfile Profile
        {
            get { return _profile; }
            set
            {
                SetProperty(ref _profile, value, nameof(Profile));
                if (value == null)
                {
                    ProfilePicture = null;
                    Gamertag = string.Empty;
                    Gamerscore = 0;
                    Bio = string.Empty;
                    Location = string.Empty;
                    Tier = string.Empty;
                    Reputation = string.Empty;
                    RealName = string.Empty;
                    Primary = new SolidColorBrush(Colors.White);
                    Secondary = new SolidColorBrush(Colors.White);
                    Tertiary = new SolidColorBrush(Colors.White);
                }
                else
                {
                    ProfilePicture = value.GamerPic;
                    Gamertag = value.Gamertag;
                    Gamerscore = value.Gamerscore;
                    Bio = value.Bio;
                    Location = value.Location;
                    Tier = value.AccountTier;
                    Reputation = value.Reputation;
                    RealName = value.RealName;
                    Primary = new SolidColorBrush((Color)ColorConverter.ConvertFromString(string.Format("#{0}", value.PreferredColor.PrimaryColor)));
                    Secondary = new SolidColorBrush((Color)ColorConverter.ConvertFromString(string.Format("#{0}", value.PreferredColor.SecondaryColor)));
                    Tertiary = new SolidColorBrush((Color)ColorConverter.ConvertFromString(string.Format("#{0}", value.PreferredColor.TertiaryColor)));
                }
            }
        }

        public Uri ProfilePicture
        {
            get { return _profilePicture; }
            set { SetProperty(ref _profilePicture, value, nameof(ProfilePicture)); }
        }
        public string Gamertag
        {
            get { return _gamertag; }
            set { SetProperty(ref _gamertag, value, nameof(Gamertag)); }
        }
        public int Gamerscore
        {
            get { return _gamerscore; }
            set { SetProperty(ref _gamerscore, value, nameof(Gamerscore)); }
        }
        public string Bio
        {
            get { return _bio; }
            set { SetProperty(ref _bio, value, nameof(Bio)); }
        }
        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value, nameof(Location)); }
        }
        public string Tier
        {
            get { return _tier; }
            set { SetProperty(ref _tier, value, nameof(Tier)); }
        }
        public string Reputation
        {
            get { return _reputation; }
            set { SetProperty(ref _reputation, value, nameof(Reputation)); }
        }
        public string RealName
        {
            get { return _realName; }
            set { SetProperty(ref _realName, value, nameof(RealName)); }
        }
        public Brush Primary
        {
            get { return _primary; }
            set { SetProperty(ref _primary, value, nameof(Primary)); }
        }
        public Brush Secondary
        {
            get { return _secondary; }
            set { SetProperty(ref _secondary, value, nameof(Secondary)); }
        }
        public Brush Tertiary
        {
            get { return _tertiary; }
            set { SetProperty(ref _tertiary, value, nameof(Tertiary)); }
        }
    }
}
