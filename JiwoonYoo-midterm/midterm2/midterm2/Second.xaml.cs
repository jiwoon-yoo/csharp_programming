using midterm2;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Xml.Linq;

namespace midterm2
{

    public partial class Second : Window
    {

        private List<Person> personList = new List<Person>();
        public Second()
        {
            InitializeComponent();

            personList.Add(new Person(0, 101, "John", "845 Sherbrooke St W, Montreal, Quebec H3A 0G4, Canada", "john@gmail.com", 21, "1991-01-01"));
            personList.Add(new Person(1, 102, "Mark", "836W+J4 Kanata, Ottawa, ON, Canada", "mark@gmail.com", 22, "1992-02-02"));
            personList.Add(new Person(2, 103, "David", "41 Dalvay Crescent, Dalvay by the Sea, PE C0A 1P0, Canada", "david@gmail.com", 23, "1993-03-03"));
            personList.Add(new Person(3, 104, "James", "5955 Ross St, Vancouver, BC V5W 1T7, Canada", "james@gmail.com", 24, "1994-04-04"));
            personList.Add(new Person(4, 105, "Alan", "750 9 Ave SE, Calgary, AB T2G 5E1, Canada", "alan@gmail.com", 25, "1995-05-05"));

            var names = from emp in personList                                                                 //in 
                        select emp.Name;

            lstPerson.DataContext = names;
        }


        private void lstPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstPerson.SelectedIndex;                                                               //SelectedIndex 
            var selectedPerson = from per in personList
                                 where per.Index == i
                                 select per;

            foreach (var s in selectedPerson)                                                              //notice. even if it's one line, use foreach()
            {
                txtPersonId.Text = s.PersonId.ToString();
                txtName.Text = s.Name;
                txtAddress.Text = s.Address;
                txtEmail.Text = s.Email;
                txtAge.Text = s.Age.ToString();
                txtBirthDay.Text = s.BirthDay;
            }
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonId.Text == "" || txtName.Text == "" ||
                txtAddress.Text == "" || txtEmail.Text == "" ||
                txtAge.Text == "" || txtBirthDay.Text == "")
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
            else
            {
                personList.Add(new Person(personList.Count, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text));




                var names = from per in personList                                                            //notice. declare necessary in this case
                            select per.Name;

                lstPerson.DataContext = names;
            }
        }



        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to update it?", "update", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {

                if (txtPersonId.Text == "" || txtName.Text == "" ||
                txtAddress.Text == "" || txtEmail.Text == "" ||
                txtAge.Text == "" || txtBirthDay.Text == "")
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
                else
                {

                    Person per = new Person(lstPerson.SelectedIndex, int.Parse(txtPersonId.Text), txtName.Text,
                               txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text);
                    personList[lstPerson.SelectedIndex] = per;




                    var names = from per2 in personList
                                select per2.Name;

                    lstPerson.DataContext = names;
                }
            }



        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to delete it?", "delete", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {

                personList.RemoveAt(lstPerson.SelectedIndex);


                for (int i = 0; i < personList.Count; i++)
                    personList[i].PersonId = i;




                var names = from per3 in personList
                            select per3.Name;

                lstPerson.DataContext = names;


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

