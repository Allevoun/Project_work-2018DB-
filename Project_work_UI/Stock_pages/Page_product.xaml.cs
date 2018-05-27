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
using Project_work_DB.Repository;

namespace Project_work_UI.Stock_pages
{
    /// <summary>
    /// Логика взаимодействия для Page_product.xaml
    /// </summary>
    public partial class Page_product : Page
    {
        public Page_product()
        {
            InitializeComponent();
            DBaccess dbentree = new DBaccess();
            SQLquery sqlmessage = new SQLquery();

            ProductList = dbentree.GetDBInfo<PRODUCT>(sqlmessage.Query_Product);
        }

        List<PRODUCT> ProductList = new List<PRODUCT>();
    }
}
