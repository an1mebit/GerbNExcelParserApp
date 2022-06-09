using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amogus.Core;
using System.Windows.Input;
using amogus.MVVM.View;

namespace amogus.MVVM.ViewModel
{
    class DataExcelViewModel : ObservObject
    {
        static public string text1 = "";
        static public string text2 = "";
        static public string text3 = "";
        static public string text4 = "";
        static public string text5 = "";
        static public string text6 = "";
        static public string text7 = "";

        private object _textbox1;

        public object textbox1
        {
            get { return _textbox1; }
            set
            {
                _textbox1 = value;
                OnPropertChanceged();
            }
        }

        public DataExcelViewModel()
        {
            
        }
    }

}
