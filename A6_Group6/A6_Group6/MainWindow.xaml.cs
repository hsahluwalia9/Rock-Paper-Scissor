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

namespace A6_Group6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            DataContext = vm;
        }

        private void BtnScissor_Click(object sender, RoutedEventArgs e)
        {
            
           
            
        }

        private void BtnPaper_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnRock_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnBegin_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
