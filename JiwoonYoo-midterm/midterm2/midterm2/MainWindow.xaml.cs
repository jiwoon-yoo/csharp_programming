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

namespace midterm2
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

        private void btnPerson_Click(object sender, RoutedEventArgs e)
        {
            Second second = new Second();
            second.Show();
        }

        private void btnSportTeam_Click(object sender, RoutedEventArgs e)
        {
            Third third = new Third();
            third.Show();
        }

        private void btnPersonality_Click(object sender, RoutedEventArgs e)
        {
            Fourth fourth = new Fourth();
            fourth.Show();
        }

        private void Education_Click(object sender, RoutedEventArgs e)
        {
            Fifth fifth = new Fifth();
            fifth.Show();
        }









        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("new clicked");
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("save clicked");
        }


        private void mnuQuit_Click(object sender, RoutedEventArgs e)
        {

            var result = MessageBox.Show("do you want to quit the application?", "quit", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
                 

        }





        private void mnuHelp_Click(object sender, RoutedEventArgs e)
        {
            Information infoWindow = new Information();
            infoWindow.Height = 200;
            infoWindow.Width = 400;
            infoWindow.Show();
        }
    }
}
