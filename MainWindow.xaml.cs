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
        public MainWindow()
        {
            InitializeComponent();

            var order = DataGetMethods.GetOrders();
            GridOrdersAll.ItemsSource = order;


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

        private void NewOrder(object sender, RoutedEventArgs e)
        {

        }

        private void Selected(object sender, MouseButtonEventArgs e)
        {

        }
    }
}