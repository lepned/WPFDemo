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
using System.Windows.Shapes;

namespace DemoForRamin.Windows
{
    /// <summary>
    /// Interaction logic for ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModels.ChildViewModel;
            vm.CreateLogMessage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModels.ChildViewModel;
            vm.OpenFilePicker();
        }
    }
}
