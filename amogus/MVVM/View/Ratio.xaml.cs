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
using amogus.MVVM.ViewModel;

namespace amogus.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для Ratio.xaml
    /// </summary>
    public partial class Ratio : UserControl
    {
        public Ratio()
        {
            InitializeComponent();
            TextBox1.Text = RatioViewModel.koef1;
            TextBox2.Text = RatioViewModel.koef2;
            TextBox3.Text = RatioViewModel.koef3;
            TextBox4.Text = RatioViewModel.koef4;
            TextBox5.Text = RatioViewModel.koef5;
            TextBox6.Text = RatioViewModel.koef6;
            TextBox7.Text = RatioViewModel.koef7;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef1 = textBox.Text;
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef2 = textBox.Text;
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef3 = textBox.Text;
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef4 = textBox.Text;
        }

        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef5 = textBox.Text;
        }

        private void TextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef6 = textBox.Text;
        }

        private void TextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RatioViewModel.koef7 = textBox.Text;
        }
    }
}
