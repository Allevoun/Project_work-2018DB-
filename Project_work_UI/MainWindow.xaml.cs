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
            Logic.FrameContentxPage(Pproduct, Frame_mainpages);
        }

        private void btn_sales_Click(object sender, RoutedEventArgs e)
        {
            Page_sales Psales = new Page_sales();
            Logic.FrameContentxPage(Psales, Frame_mainpages);
        }

        private void btn_promotions_Click(object sender, RoutedEventArgs e)
        {
            Page_promotion Ppromotion = new Page_promotion();
            Logic.FrameContentxPage(Ppromotion, Frame_mainpages);

        }

        private void btn_adversisdment_Click(object sender, RoutedEventArgs e)
        {
            Page_adversisment Padversisment = new Page_adversisment();
            Logic.FrameContentxPage(Padversisment, Frame_mainpages);
        }

        private void btn_market_Click(object sender, RoutedEventArgs e)
        {
            Page_market Pmarket = new Page_market();
            Logic.FrameContentxPage(Pmarket, Frame_mainpages);
        }

        private void btn_managers_Click(object sender, RoutedEventArgs e)
        {
            Page_managers Pmanagers = new Page_managers();
            Logic.FrameContentxPage(Pmanagers, Frame_mainpages);
        }
    }
}
