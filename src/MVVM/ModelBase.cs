using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalakoi.Xbox.App
{
    public abstract class ModelBase : PropertyChangedBase
    {
        public void SetProperty<T>(ref T storage, T value, string name)
        {
            if ((storage?.GetType() != value?.GetType()) && storage != null && value != null)
                throw new InvalidCastException("Nexthermal.CodeBase.WPF.ModelBase.UpdateProperty\nVariable type mismatch between storage and value.");
            storage = value;
            OnPropertyChanged(name);
        }
    }
}
