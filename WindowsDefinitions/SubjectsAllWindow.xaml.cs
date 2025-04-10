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
using Zakázky.DataGetSet;

namespace Zakázky.WindowsDefinitions
{
    /// <summary>
    /// Interakční logika pro SubjectsAllWindow.xaml
    /// </summary>
    public partial class SubjectsAllWindow : Window
    {
        public SubjectsAllWindow()
        {
            InitializeComponent();
            var Subjects = DataGetMethods.GetSubjects();
            DataSubjectGrid.ItemsSource = Subjects;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void New(object sender, RoutedEventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.Show();
            
        }
    }
}
