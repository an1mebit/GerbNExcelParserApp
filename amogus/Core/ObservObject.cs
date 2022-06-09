using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace amogus.Core
{
    public class ObservObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertChanceged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
