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
using Project_work_DB;
using Project_work_UI.Stock_pages;

namespace Project_work_UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btn_product_Click(object sender, RoutedEventArgs e)
        {
            Page_product Pproduct = new Page_product();

            Pproduct.Width = Frame_mainpages.Width;
            Pproduct.Height = Frame_mainpages.Height;
            Frame_mainpages.Content = Pproduct;
        }

        private void btn_sales_Click(object sender, RoutedEventArgs e)
        {
            Page_sales Psales = new Page_sales();

            Psales.Width = Frame_mainpages.Width;
            Psales.Height = Frame_mainpages.Height;
            Frame_mainpages.Content = Psales;
        }
    }
}
