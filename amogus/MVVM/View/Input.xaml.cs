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
using Microsoft.Win32;
using amogus.MVVM.Model;
using System.Data;

namespace amogus.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : UserControl
    {
        public Input()
        {
            InitializeComponent();
        }

        ExcelCalculationModel excelModel { get; set; }
        ColumnsNRows data { get; set; }

        private void OpenDialogButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".xlsx";
            ofd.Filter = "Text files (*.xlsx)|*.xlsx";
            Nullable<bool> result = ofd.ShowDialog();

            if (result == true)
            {
                string filename = ofd.FileName;
                TextBoxDialog.Text = filename;
            }
        }

        static public DataView? db;

        private void TextBoxDialog_KeyDown(object sender, KeyEventArgs e)
        {
            excelModel = new ExcelCalculationModel();
            if (e.Key == Key.Enter)
            {
                if (System.IO.Path.GetExtension(TextBoxDialog.Text.ToString()) == ".xlsx")
                {
                    var text = TextBoxDialog.Text.ToString();
                    ExcelCalculationModel.excelFilename = text.Replace(@"\\", @"\");
                    db = excelModel.ReadFile(ExcelCalculationModel.excelFilename);
                }
                else
                {
                    MessageBox.Show("[ERR] Неправильное расширение файла");
                }
            }
        }

        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            excelModel = new ExcelCalculationModel();

            if (System.IO.Path.GetExtension(TextBoxDialog.Text.ToString()) == ".xlsx")
            {
                var text = TextBoxDialog.Text.ToString();
                ExcelCalculationModel.excelFilename = text.Replace(@"\\", @"\");
                db = excelModel.ReadFile(ExcelCalculationModel.excelFilename);
            }
            else
            {
                MessageBox.Show("[ERR] Неправильное расширение файла");
            }
        }
    }
}
