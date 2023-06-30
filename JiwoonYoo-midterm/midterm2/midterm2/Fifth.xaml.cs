using midterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Fifth : Window
    {
        private List<Education> educationList = new List<Education>();

        public Fifth()
        {
            InitializeComponent();

            educationList.Add(new Education(0, 101, "John", "845 Sherbrooke St W, Montreal, Quebec H3A 0G4, Canada", "john@gmail.com", 21, "1991-01-01", 401, "Math", 90, "this is a math course"));
            educationList.Add(new Education(1, 102, "Mark", "836W+J4 Kanata, Ottawa, ON, Canada", "mark@gmail.com", 22, "1992-02-02", 402, "Data Science", 91, "this is a data science course"));
            educationList.Add(new Education(2, 103, "David", "1 Rue des Carrières, Québec, QC G1R 4P5, Canada", "david@gmail.com", 23, "1993-03-03", 403, "Physics", 92, "this is a physics course"));
            educationList.Add(new Education(3, 104, "James", "5955 Ross St, Vancouver, BC V5W 1T7, Canada", "james@gmail.com", 24, "1994-04-04", 404, "Chemistry", 93, "this is a chemistry course"));
            educationList.Add(new Education(4, 105, "Alan", "750 9 Ave SE, Calgary, AB T2G 5E1, Canada", "alan@gmail.com", 25, "1995-05-05", 405, "Java", 94, "this is a java course"));


            var names = from edu in educationList
                        select edu.Name;

            lstEducation.DataContext = names;

        }

        private void lstEducation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lstEducation.SelectedIndex;
            var selectedEducation = from edu in educationList
                                    where edu.Index == i
                                    select edu;

            foreach (var s in selectedEducation)
            {
                txtPersonId.Text = s.PersonId.ToString();
                txtName.Text = s.Name;
                txtAddress.Text = s.Address;
                txtEmail.Text = s.Email;
                txtAge.Text = s.Age.ToString();
                txtBirthDay.Text = s.BirthDay;

                txtEducationId.Text = s.EducationId.ToString();
                txtCourseName.Text = s.CourseName;
                txtCourseGrade.Text = s.CourseGrade.ToString();
                txtComment.Text = s.Comment;
            }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonId.Text == "" || txtName.Text == "" ||
                txtAddress.Text == "" || txtEmail.Text == "" ||
                txtAge.Text == "" || txtBirthDay.Text == "" ||
                txtEducationId.Text == "" || txtCourseName.Text == "" ||
                txtCourseGrade.Text == "" || txtComment.Text == ""
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


            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEducationId.Text, "^[0-9]"))
            {
                MessageBox.Show("education id has to be a integer value", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCourseGrade.Text, @"^[1-9]*.\d*|0.\d*[1-9]\d*$"))
            {
                MessageBox.Show("grade has to be a floating point number or an integer number", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                educationList.Add(new Education(educationList.Count, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtEducationId.Text), txtCourseName.Text, Double.Parse(txtCourseGrade.Text), txtComment.Text));




                var names = from edu in educationList                                                            //notice. declare necessary in this case
                            select edu.Name;

                lstEducation.DataContext = names;
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
                txtEducationId.Text == "" || txtCourseName.Text == "" ||
                txtCourseGrade.Text == "" || txtComment.Text == ""
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


                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtEducationId.Text, "^[0-9]"))
                {
                    MessageBox.Show("education id has to be a integer value", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCourseGrade.Text, @"^[1-9]*.\d*|0.\d*[1-9]\d*$"))
                {
                    MessageBox.Show("grade has to be a floating point number or an integer number", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {


                    Education edu = new Education(lstEducation.SelectedIndex, int.Parse(txtPersonId.Text), txtName.Text,
                            txtAddress.Text, txtEmail.Text, int.Parse(txtAge.Text), txtBirthDay.Text, int.Parse(txtEducationId.Text), txtCourseName.Text, Double.Parse(txtCourseGrade.Text), txtComment.Text);


                    educationList[lstEducation.SelectedIndex] = edu;




                    var names = from edu2 in educationList
                                select edu2.Name;

                    lstEducation.DataContext = names;
                }
            }

        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("do you want to delete it?", "delete", MessageBoxButton.YesNo, MessageBoxImage.Information);            //MessageBox.Show 1.show 2.return MessageBoxButton.OK 
            if (result == MessageBoxResult.Yes)
            {
                educationList.RemoveAt(lstEducation.SelectedIndex);


                for (int i = 0; i < educationList.Count; i++)
                    educationList[i].PersonId = i;




                var names = from edu3 in educationList
                            select edu3.Name;

                lstEducation.DataContext = names;
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
