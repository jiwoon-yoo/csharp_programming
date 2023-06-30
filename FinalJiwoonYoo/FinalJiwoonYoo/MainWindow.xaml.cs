using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalJiwoonYoo
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


        private void GetDataFromDb()       
        {
            using (var context = new NorthwindEntities())
            {
                var products = context.Products.ToList();               
                FillDataGrid(products);                                 
            }
        }

        private void FillDataGrid(List<Product> products)       
        {
            grdProducts.ItemsSource = products;

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

        private void cmbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1)
            {
                using (var context = new NorthwindEntities())
                {
                    int catId = (int)cmbCategories.SelectedValue;

                    var product = (from prd in context.Products
                                   where prd.CategoryID == catId
                                   select prd).ToList();

                    FillDataGrid(product);
                    txtName.Text = "";
                }
            }
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            GetDataFromDb();
        }

        private void btnClearData_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            cmbCategories.SelectedIndex = -1;                 
            grdProducts.ItemsSource = null;         
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new NorthwindEntities())
                {
                 
                    var products = (from prd in context.Products
                                    where prd.ProductName.Contains(txtName.Text)
                                    select prd).ToList();                                       

                    FillDataGrid(products);      
                }

                cmbCategories.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();

            win2.ShowDialog();

        }
    }
}
