using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kalakoi.Xbox.App
{
    public abstract class LauncherModel : ModelBase
    {
        private string _key;
        private ICommand _launch;

        public string Key
        {
            get { return _key; }
            set { SetProperty(ref _key, value, nameof(Key)); }
        }
        public ICommand Launch
        {
            get { return _launch; }
            set { SetProperty(ref _launch, value, nameof(Launch)); }
        }
    }
}
