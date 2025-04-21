using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zakázky.DataGetSet;
using Zakázky.DB_Class;
using Zakázky.WindowsDefinitions;

namespace Zakázky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Order> active
        {
            get
            {
                return allOrders.Where(e => !e.IsDeleted).ToList();
            }
        }
        List<Order> deleted
        {
            get
            {
                return allOrders.Where(e => e.IsDeleted).ToList();
            }
        }
        ObservableCollection<Order> allOrders = new();
        //Metody pro klávesové zkratky ve WPF
        public static readonly RoutedUICommand NewCommand = new RoutedUICommand("New", "NewCommand", typeof(MainWindow));
        public static readonly RoutedUICommand DeleteCommand = new RoutedUICommand("Delete", "DeleteCommand", typeof(MainWindow));
        public static readonly RoutedUICommand EditCommand = new RoutedUICommand("Edit", "EditCommand", typeof(MainWindow));
        public static readonly RoutedUICommand RefreshCommand = new RoutedUICommand("Refresh", "RefreshCommand", typeof(MainWindow));
        public MainWindow()
        {
            InitializeComponent();
            allOrders.CollectionChanged += CheckboxChanged;

            allOrders = new(DataGetMethods.GetOrders());
            DataOrderGrid.ItemsSource = active;

        }
        private void CheckboxChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            DataOrderGrid.ItemsSource = (CheckboxDeleted?.IsChecked ?? false) ? deleted : active;
            DataOrderGrid.Items.Refresh();
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();           
        }

        private void ViewSubjectList(object sender, RoutedEventArgs e)
        {
           SubjectsAllWindow subjectsAllWindow = new SubjectsAllWindow();       
            subjectsAllWindow.Show();

        }

        private void AddNewSubject(object sender, RoutedEventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.Show();


        }

        private void SearchOrder(object sender, RoutedEventArgs e)
        {

        }

        private void AboutWindow(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Vypracoval ten největší borec ze všech.");
        }

        private void New(object sender, RoutedEventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.Show();

        }

        private void Selected(object sender, MouseButtonEventArgs e)
        {

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            Order Selected = (Order)DataOrderGrid.SelectedItem;

            if (Selected != null)
            {
                AddOrder addOrder = new ();
                addOrder.Insert(Selected);
                addOrder.ShowDialog();
                DataOrderGrid.Items.Refresh();
            }

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Order Selected = (Order)DataOrderGrid.SelectedItem;

            if (Selected != null)
            {
                Selected.IsDeleted = !Selected.IsDeleted;
                DataOrderGrid.ItemsSource = (CheckboxDeleted?.IsChecked ?? false) ? deleted : active;
                DataOrderGrid.Items.Refresh();
                DataSetMethods.Update(Selected);

            }
        }

        private void MouserRigtAction(object sender, MouseButtonEventArgs e)
        {

        }



        private void ShowActive(object sender, RoutedEventArgs e)
        {
            DataOrderGrid.ItemsSource = active;
            DataOrderGrid.Items.Refresh();
        }
        private void ShowDeleted(object sender, RoutedEventArgs e)
        {
            DataOrderGrid.ItemsSource = deleted;
            DataOrderGrid.Items.Refresh();
        }
        private void Refresh(object sender, RoutedEventArgs e)
        {
            DataOrderGrid.Items.Refresh();

        }


    }
}