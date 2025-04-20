using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Microsoft.Identity.Client;
using Zakázky.DataGetSet;
using Zakázky.DB_Class;

namespace Zakázky.WindowsDefinitions
{
    /// <summary>
    /// Interakční logika pro AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Window
    {
        public ObservableCollection<Subject> allsubjects = new();

        public AddOrder()
        {
            InitializeComponent();
            allsubjects = new(DataGetMethods.GetSubjects().Where(e => !e.IsDeleted).ToList());    
            SubjectComboBox.ItemsSource = allsubjects;
            OrderTypeComboBox.ItemsSource = Enum.GetValues(typeof(OrderType));
            OrderStateComboBox.ItemsSource = Enum.GetValues(typeof(OrderState));

            // Incialializace DatePickeru
            DatePicker.DisplayDate = DateTime.Now;
            DatePicker.SelectedDate = DateTime.Now; 

        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {

        }

        private void WindowClose(object sender, RoutedEventArgs e)
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