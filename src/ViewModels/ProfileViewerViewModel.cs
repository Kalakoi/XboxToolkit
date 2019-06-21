using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalakoi.Xbox.OpenXBL;

namespace Kalakoi.Xbox.App
{
    public class ProfileViewerViewModel : ProfileViewerModel
    {
        public ProfileViewerViewModel()
        {
            InitializeVariables();
            InitializeCommands();
        }

        private void InitializeVariables()
        {
            Profile = null;
        }

        private void InitializeCommands()
        {

        }

        public void LoadProfile(XboxProfile profile)
        {
            Profile = profile;
        }
    }
}
