using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amogus.MVVM.ViewModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace amogus.MVVM.Model
{
    class NavigationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public InputViewModel InputVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        private void OpenVokerInput(object param)
        {
            if (param.ToString() == "inputViewCommand")
            {
                CurrentView = new InputViewModel();
            }
        }

        public NavigationModel()
        {
            CurrentView = 0;
        }
    }

    class InputNavigateModel
    {
        private readonly Action<object> navigate;

        public ICommand Navigate { get; set; }

        public InputNavigateModel(Action<object> navigate)
        {
        }

        private void onNavigate(object param)
        {
            navigate.Invoke("input");
        }
    }
}
