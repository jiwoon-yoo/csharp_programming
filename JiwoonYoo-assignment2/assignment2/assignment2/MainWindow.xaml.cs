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
using System.Data.SqlClient;
using System.Data;
using WpfDisconnectedModels;

namespace assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Data data = new Data(); 

        public MainWindow()
        {
            InitializeComponent();

            cmbCategories.ItemsSource = data.GetAllCategories().DefaultView;

            cmbCategories.DisplayMemberPath = "CategoryName";
            cmbCategories.SelectedValuePath = "CategoryID";
        }

        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
            grdProducts.ItemsSource = data.GetAllProducts().DefaultView;
        }

        private void cmbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int catId = (int)cmbCategories.SelectedValue;

            grdProducts.ItemsSource = data.GetAllProductsByCategoryId(catId).DefaultView; 


        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int catId = int.Parse(txtId.Text);

            grdProducts.ItemsSource = data.GetAllProductsByCategoryId(catId).DefaultView;

            
        }


     
    }
}
