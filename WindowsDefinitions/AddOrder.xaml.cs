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

namespace Zakázky.WindowsDefinitions
{
    /// <summary>
    /// Interakční logika pro AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {

        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewOrderItem(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteOrderItem(object sender, RoutedEventArgs e)
        {

        }

        private void ClickMouseRightAction(object sender, MouseButtonEventArgs e)
        {

        }

        private void MyDataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

        }
    }
}
