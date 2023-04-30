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

namespace TextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Reset();
        }

        private void Reset()
        {
            firstName.Text = String.Empty;
        }

        private void Clear_Event(object sender, MouseButtonEventArgs e)
        {
            this.Reset();
        }

        private void Submit_Event(object sender, MouseButtonEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(firstName.Text);

            MessageBox.Show(sb.ToString(), "Submit");
        }

        private void Clear_Event(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(firstName.Text);

            MessageBox.Show(sb.ToString(), "Submit");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Reset();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Ban co muon thoat khoi ung dung?", "Xac nhan", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No); 

            e.Cancel = (res == MessageBoxResult.No);
        }
    }
}
