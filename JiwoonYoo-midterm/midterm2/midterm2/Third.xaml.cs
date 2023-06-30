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
    public partial class Third : Window
    {
        private List<SportTeam> sportTeamList = new List<SportTeam>();

        public Third()
        {
            InitializeComponent();

            sportTeamList.Add(new SportTeam(0, 101, "John", "845 Sherbrooke St W, Montreal, Quebec H3A 0G4, Canada", "john@gmail.com", 21, "1991-01-01", 201, "team1", "Sherbrooke"));
            sportTeamList.Add(new SportTeam(1, 102, "Mark", "836W+J4 Kanata, Ottawa, ON, Canada", "mark@gmail.com", 22, "1992-02-02", 202, "team2", "Ottawa"));
            sportTeamList.Add(new SportTeam(2, 103, "David", "1 Rue des Carrières, Québec, QC G1R 4P5, Canada", "david@gmail.com", 23, "1993-03-03", 203, "team3","Quebec City" ));
            sportTeamList.Add(new SportTeam(3, 104, "James", "5955 Ross St, Vancouver, BC V5W 1T7, Canada", "james@gmail.com", 24, "1994-04-04", 204, "team3", "Vancouver"));
            sportTeamList.Add(new SportTeam(4, 105, "Alan", "750 9 Ave SE, Calgary, AB T2G 5E1, Canada", "alan@gmail.com", 25, "1995-05-05", 205, "team5", "Calgary"));


            var names = from spor in sportTeamList                                                                 
                        select spor.Name;

            lstSportTeam.DataContext = names;

        }

        private void lstSportTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstSportTeam.SelectedIndex;                                                              
            var selectedSportTeam = from per in sportTeamList
                                 where per.Index == i
                                 select per;

            foreach (var s in selectedSportTeam)                                                              
            {
                txtPersonId.Text = s.PersonId.ToString();
                txtName.Text = s.Name;
                txtAddress.Text = s.Address;
                txtEmail.Text = s.Email;
                txtAge.Text = s.Age.ToString();
                txtBirthDay.Text = s.BirthDay;

                txtSportTeamId.Text = s.SportTeamId.ToString(); 
                txtSportTeamName.Text = s.SportTeamName;
                txtCity.Text = s.City;
            }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonId.Text == "" || txtName.Text == "" ||
                txtAddress.Text == "" || txtEmail.Text == "" ||
                txtAge.Text == "" || txtBirthDay.Text == "" ||
                txtSportTeamId.Text == "" || txtSportTeamName.Text == "" ||
                txtCity.Text == ""
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

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtSportTeamId.Text, "^[0-9]"))
            {
                MessageBox.Show("sport team id has to be a integer value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCity.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("city has to be a string value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {
                sportTeamList.Add(new SportTeam(sportTeamList.Count, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtSportTeamId.Text), txtSportTeamName.Text, txtCity.Text));




                var names = from spor in sportTeamList                                                            //notice. declare necessary in this case
                            select spor.Name;

                lstSportTeam.DataContext = names;
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
                txtSportTeamId.Text == "" || txtSportTeamName.Text == "" ||
                txtCity.Text == ""
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

                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtSportTeamId.Text, "^[0-9]"))
                {
                    MessageBox.Show("sport team id has to be a integer value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCity.Text, "^[a-zA-Z ]*$"))
                {
                    MessageBox.Show("city has to be a string value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

                else
                {



                    SportTeam spor = new SportTeam(lstSportTeam.SelectedIndex, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtSportTeamId.Text), txtSportTeamName.Text, txtCity.Text);


                    sportTeamList[lstSportTeam.SelectedIndex] = spor;




                    var names = from spor2 in sportTeamList
                                select spor2.Name;

                    lstSportTeam.DataContext = names;
                }
            }

            
        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to delete it?", "delete", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {
                sportTeamList.RemoveAt(lstSportTeam.SelectedIndex);


                for (int i = 0; i < sportTeamList.Count; i++)
                    sportTeamList[i].PersonId = i;




                var names = from spor3 in sportTeamList
                            select spor3.Name;

                lstSportTeam.DataContext = names;
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
