using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amogus.Core;
using amogus.MVVM.View;
using amogus.MVVM.Model;
using System.Windows.Input;
using System.Windows.Data;
using System.IO;

namespace amogus.MVVM.ViewModel
{
    class MainViewModel : ObservObject
    {

        public CommandHandler homeViewCommand { get; set; }

        public CommandHandler inputViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public InputViewModel InputVM { get; set; }

        public DataExcelViewModel DataExcelVM { get; set; } 

        public RatioViewModel RatioVM { get; set; }

        public ExcelCalculationModel ExcelCalculationM { get; set; }

        public Home HomeView { get; set; }

        private object _currentView;

        private object _customHeight;

        private object _isVisible;

        private object _addedText;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertChanceged();
            }
        }

        public object customHeight
        {
            get { return _customHeight; }
            set
            {
                _customHeight = value;
                OnPropertChanceged();
            }
        }

        public object isVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertChanceged();
            }
        }

        public object addedText
        {
            get { return _addedText; }
            set
            {
                _addedText = value;
                OnPropertChanceged();
            }
        }

        public MainViewModel()
        {
            customHeight = 200;
            HomeView = new Home();
            HomeVM = new HomeViewModel();
            InputVM = new InputViewModel();
            DataExcelVM = new DataExcelViewModel();
            RatioVM = new RatioViewModel();
            ExcelCalculationM = new ExcelCalculationModel();
            CurrentView = HomeVM;

            homeViewCommand = new CommandHandler(o =>
            {
                CurrentView = HomeVM;
            });
            
            inputViewCommand = new CommandHandler(o =>
            {
                CurrentView = InputVM;
            });

        }

        public ICommand getInputViewModel => new CommandHandler(o => { CurrentView = InputVM; });

        public ICommand getDataExcelViewModel => new CommandHandler(o => { CurrentView = DataExcelVM; });

        public ICommand getRatioViewModel => new CommandHandler(o => { CurrentView = RatioVM; });

        public ICommand changeHeight => new CommandHandler(o => {
            if (customHeight.ToString() == "200")
            {
                customHeight = 60;
                isVisible = "Hidden";
            }
            else
            {
                customHeight = 200;
                isVisible = "Visible";
            }
        });

        public ICommand getResult => new CommandHandler(o => {
            List<double> result = ExcelCalculationM.GetRusultOfCalculations();
            if (result.Count != 0)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    addedText += "" + (i + 1) + ": " + result[i].ToString("#.000") + "\n";
                }
            }
        });
    }

}
