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

namespace FinalJiwoonYoo
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new NorthwindEntities())
            {
                var categories = context.Categories.ToList();

                cmbCategories.ItemsSource = categories;
                cmbCategories.DisplayMemberPath = "CategoryName";
                cmbCategories.SelectedValuePath = "CategoryID";

            }
        }


        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new NorthwindEntities())
            {

                Product prd = new Product();                           
                prd.ProductName = txtName.Text;
                prd.UnitPrice = decimal.Parse(txtPrice.Text);
                prd.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);              

                context.Products.Add(prd);                       

                context.SaveChanges();  

                MessageBox.Show("New product Added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
