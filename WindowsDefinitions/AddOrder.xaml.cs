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
        private bool editingmode = false;
        private Order EOrder = new();
        public void Insert(Order order)
        {
            editingmode = true;
            EOrder = order;
            DateOrder.SelectedDate = order.OrderDate;
            OName.Text = order.OrderName;
            OType.SelectedItem = order.orderType;
            OState.SelectedItem = order.orderState;
            ODescription.Text = order.OrderDescription;
            ONote.Text = order.OrderNote;
            OCustomer.SelectedItem = order.Custumer;
        }

        bool Validation()
        {
            if (DateOrder.SelectedDate == null)
            {
                System.Windows.MessageBox.Show("Vyplň datum objednávky!");
                return false;
            }
            if (!decimal.TryParse(EstimatedCost.Text, out _))
            {
                System.Windows.MessageBox.Show("Uveď hodnotu odhadované ceny!");
                return false;
            }
            if (!decimal.TryParse(TotalCost.Text, out _))
            {
                System.Windows.MessageBox.Show("Uveď hodnotu koncové ceny!");
                return false;
            }
            return true;
        }
        public ObservableCollection<Subject> allsubjects = new();

        public AddOrder()
        {
            InitializeComponent();
            allsubjects = new(DataGetMethods.GetSubjects().Where(e => !e.IsDeleted).ToList());
            OCustomer.ItemsSource = allsubjects;
            OType.ItemsSource = Enum.GetValues(typeof(OrderType));
            OState.ItemsSource = Enum.GetValues(typeof(OrderState));

            // Incialializace propert XML
            DateOrder.DisplayDate = DateTime.Now;
            DateOrder.SelectedDate = DateTime.Now;
            EstimatedCost.Text = "0";
            TotalCost.Text = "0";
            

        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {
            if (!Validation())
                return;

            DateTime date = (DateTime)DateOrder.SelectedDate;
            string name = OName.Text;
            OrderType type = (OrderType)OType.SelectedItem;
            OrderState state = (OrderState)OState.SelectedItem;
            string descripton = ODescription.Text;
            string note = ONote.Text;
            int customer = (Subject)OCustomer.SelectedItem;
            decimal etc = 0;//= decimal.TryParse(EstimatedCost.Text, out etc);
            decimal tc = 0;//= TotalCost;

            if (!editingmode)
            {
                DataSetMethods.SetOrder(date,name,type,state,descripton,note,customer,etc,tc);
            }
            else
            {
                DateOrder.SelectedDate = EOrder.OrderDate;
                OName.Text = EOrder.OrderName;
                OType.SelectedItem = EOrder.orderType;
                OState.SelectedItem = EOrder.orderState;
                ODescription.Text = EOrder.OrderDescription;
                ONote.Text = EOrder.OrderNote;
                OCustomer.SelectedItem = EOrder.Custumer;
                DataSetMethods.Update(EOrder);
                this.Close();  
            }
            DateOrder.SelectedDate = DateTime.Now;
            OName.Clear();
            OType.SelectedValue=null;
            OState.SelectedValue=null;  
            ODescription.Clear();
            ONote.Clear();
            OCustomer.SelectedValue = null; 


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