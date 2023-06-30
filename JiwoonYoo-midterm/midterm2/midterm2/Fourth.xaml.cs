using midterm2;
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

namespace midterm2
{
    /// <summary>
    /// Interaction logic for Third.xaml
    /// </summary>
    public partial class Fourth : Window
    {
        private List<Personality> personalityList = new List<Personality>();

        public Fourth()
        {
            InitializeComponent();

            personalityList.Add(new Personality(0, 101, "John", "845 Sherbrooke St W, Montreal, Quebec H3A 0G4, Canada", "john@gmail.com", 21, "1991-01-01", 301, 250, "movie1", "James"));
            personalityList.Add(new Personality(1, 102, "Mark", "836W+J4 Kanata, Ottawa, ON, Canada", "mark@gmail.com", 22, "1992-02-02", 302, 260, "movie2", "John"));
            personalityList.Add(new Personality(2, 103, "David", "1 Rue des Carrières, Québec, QC G1R 4P5, Canada", "david@gmail.com", 23, "1993-03-03", 303, 270, "movie3", "Harry"));
            personalityList.Add(new Personality(3, 104, "James", "5955 Ross St, Vancouver, BC V5W 1T7, Canada", "james@gmail.com", 24, "1994-04-04", 304, 280, "movie4", "Jin"));
            personalityList.Add(new Personality(4, 105, "Alan", "750 9 Ave SE, Calgary, AB T2G 5E1, Canada", "alan@gmail.com", 25, "1995-05-05", 305, 290, "movie5", "Steve"));


            var names = from per in personalityList
                        select per.Name;

            lstPersonality.DataContext = names;

        }

        private void lstPersonality_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstPersonality.SelectedIndex;
            var selectedPersonality = from per in personalityList
                                    where per.Index == i
                                    select per;

            foreach (var s in selectedPersonality)
            {
                txtPersonId.Text = s.PersonId.ToString();
                txtName.Text = s.Name;
                txtAddress.Text = s.Address;
                txtEmail.Text = s.Email;
                txtAge.Text = s.Age.ToString();
                txtBirthDay.Text = s.BirthDay;

                txtPersonalityId.Text = s.PersonalityId.ToString(); 
                txtShoeSize.Text = s.ShoeSize.ToString();
                txtFavouriteMovie.Text = s.FavouriteMovie;
                txtFavouriteActor.Text = s.FavourtieActor; 
            }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonId.Text == "" || txtName.Text == "" ||
                txtAddress.Text == "" || txtEmail.Text == "" ||
                txtAge.Text == "" || txtBirthDay.Text == "" ||
                txtPersonalityId.Text == "" || txtShoeSize.Text == "" ||
                txtFavouriteMovie.Text == "" || txtFavouriteActor.Text == ""
                )
            {
                MessageBox.Show("No text box can be empty", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPersonId.Text, "^[0-9]"))
            {
                MessageBox.Show("person id has to be a integer value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("name has to be a string value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, "^[0-9]") || int.Parse(txtAge.Text) <= 0)
            {
                MessageBox.Show("age has to be a integer value and greater than 0", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPersonalityId.Text, "^[0-9]"))
            {
                MessageBox.Show("personality id has to be a integer value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtShoeSize.Text, "^[0-9]") || int.Parse(txtShoeSize.Text) <= 0)
            {
                MessageBox.Show("shoe size has to be a integer value and greater than 0", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtFavouriteActor.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("favorite actor has to be a string value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                personalityList.Add(new Personality(personalityList.Count, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtPersonalityId.Text), int.Parse(txtShoeSize.Text), txtFavouriteMovie.Text, txtFavouriteActor.Text));




                var names = from per in personalityList                                                           
                            select per.Name;

                lstPersonality.DataContext = names;
            }
        }



        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to update it?", "update", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {

                if (txtPersonId.Text == "" || txtName.Text == "" ||
               txtAddress.Text == "" || txtEmail.Text == "" ||
               txtAge.Text == "" || txtBirthDay.Text == "" ||
               txtPersonalityId.Text == "" || txtShoeSize.Text == "" ||
               txtFavouriteMovie.Text == "" || txtFavouriteActor.Text == ""
               )
                {
                    MessageBox.Show("No text box can be empty", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPersonId.Text, "^[0-9]"))
                {
                    MessageBox.Show("person id has to be a integer value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z ]*$"))
                {
                    MessageBox.Show("name has to be a string value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, "^[0-9]") || int.Parse(txtAge.Text) <= 0)
                {
                    MessageBox.Show("age has to be a integer value and greater than 0", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtPersonalityId.Text, "^[0-9]"))
                {
                    MessageBox.Show("personality id has to be a integer value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtShoeSize.Text, "^[0-9]") || int.Parse(txtShoeSize.Text) <= 0)
                {
                    MessageBox.Show("shoe size has to be a integer value and greater than 0", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtFavouriteActor.Text, "^[a-zA-Z ]*$"))
                {
                    MessageBox.Show("favorite actor has to be a string value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {



                    Personality per = new Personality(lstPersonality.SelectedIndex, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtPersonalityId.Text), int.Parse(txtShoeSize.Text), txtFavouriteMovie.Text, txtFavouriteActor.Text);


                    personalityList[lstPersonality.SelectedIndex] = per;




                    var names = from per2 in personalityList
                                select per2.Name;

                    lstPersonality.DataContext = names;
                }


            }


            
        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to delete it?", "delete", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {
                personalityList.RemoveAt(lstPersonality.SelectedIndex);


                for (int i = 0; i < personalityList.Count; i++)
                    personalityList[i].PersonId = i;




                var names = from per3 in personalityList
                            select per3.Name;

                lstPersonality.DataContext = names;
            }

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
