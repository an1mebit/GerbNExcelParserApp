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
using amogus.MVVM.Model;
using System.Data;
using amogus.MVVM.ViewModel;

namespace amogus.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ColumnsNRows.xaml
    /// </summary>
    public partial class ColumnsNRows : UserControl
    {
        public ColumnsNRows()
        {
            InitializeComponent();

            if (Input.db != null)
            {
                DataGrid.Items.Clear();
                DataGrid.ItemsSource = Input.db;
            }

            TextBox1.Text = DataExcelViewModel.text1;
            TextBox2.Text = DataExcelViewModel.text2;
            TextBox3.Text = DataExcelViewModel.text3;
            TextBox4.Text = DataExcelViewModel.text4;
            TextBox5.Text = DataExcelViewModel.text5;
            TextBox6.Text = DataExcelViewModel.text6;
            TextBox7.Text = DataExcelViewModel.text7;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text1 = textBox.Text;
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text2 = textBox.Text;
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text3 = textBox.Text;
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text4 = textBox.Text;
        }

        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text5 = textBox.Text;
        }

        private void TextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text6 = textBox.Text;
        }

        private void TextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DataExcelViewModel.text7 = textBox.Text;
        }
    }
}
