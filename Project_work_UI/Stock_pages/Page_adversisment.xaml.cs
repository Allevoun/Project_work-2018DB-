using System;
using System.Collections.Generic;
using System.ComponentModel; // - создано автоматически 
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

namespace Project_work_UI.Stock_pages
{
    /// <summary>
    /// Логика взаимодействия для Page_adversisment.xaml
    /// </summary>
    public partial class Page_adversisment : Page
    {
        public Page_adversisment()
        {
            InitializeComponent();

            ListOfAdversisment = new List<AdTest>();
            ListOfAdversisment.Add(new AdTest() { Ad_ID = "70", Ad_place = "VK", Manager_ID = "2", Product_name = "T-shirt" });
            ListOfAdversisment.Add(new AdTest() { Ad_ID = "71", Ad_place = "FB", Manager_ID = "1", Product_name = "boots" });
            LView_adversisment.ItemsSource = ListOfAdversisment;

        }
        List<AdTest> ListOfAdversisment;

        public class AdTest
        {
            public string Ad_ID { get; set; }
            public string Ad_place { get; set; }
            public string Product_name { get; set; }
            public string Manager_ID { get; set; }
        }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        private void LView_adversismentHeader_Click(object sender, RoutedEventArgs e)
        {

            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
                    var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;

                    Sort(sortBy, direction);

                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowUp"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowDown"] as DataTemplate;
                    }

                    // Remove arrow from previously sorted header  
                    if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
                    {
                        _lastHeaderClicked.Column.HeaderTemplate = null;
                    }

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }
        }

        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView =
              CollectionViewSource.GetDefaultView(LView_adversisment.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

    }
}
