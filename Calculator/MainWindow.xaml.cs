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
using GalaSoft.MvvmLight;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirthmeticViewModel avm;
        public MainWindow()
        {          
           
            InitializeComponent();           
            avm = (AirthmeticViewModel)base.DataContext;
        }
        void SetViewModel(string Content)
        {
            avm.updateNumber = double.Parse(Content.ToString());
        }
       

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            avm.add();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            avm.clearAll();
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            avm.equal();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            avm.Multiply();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            avm.subtract();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            avm.Divide();
        }
    }
}
