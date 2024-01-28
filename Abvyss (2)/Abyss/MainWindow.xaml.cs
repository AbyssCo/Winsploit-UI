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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Abyss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void EditBTN_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("EditSlide");
            s.Begin();

        }

        private void CloudBTN_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("CloudSlide");
            s.Begin();
        }

        private void SetBTN_Checked(object sender, RoutedEventArgs e)
        {
            Storyboard s = (Storyboard)TryFindResource("SetSlide");
            s.Begin();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
