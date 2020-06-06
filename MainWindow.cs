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

namespace HelloworldGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string calculate1;

        public MainWindow()
        {
            InitializeComponent();
        }     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double calculate1 = double.Parse(txtPrice.Text) / (double.Parse(txtIncome.Text) - double.Parse(txtExpense.Text));
            txtDay.Text = $"{(calculate1)}";
        }
        private void txtDay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
