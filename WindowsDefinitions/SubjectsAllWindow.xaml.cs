using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
    /// Interakční logika pro SubjectsAllWindow.xaml
    /// </summary>
    public partial class SubjectsAllWindow : Window
    {
        List<Subject> active
        {
            get
            {
                return allSubjects.Where(e => !e.IsDeleted).ToList();
            }
        }
        List<Subject> deleted
        {
            get
            {
                return allSubjects.Where(e => e.IsDeleted).ToList();
            }
        }

        ObservableCollection<Subject> allSubjects = new();
  
        
        public SubjectsAllWindow()
        {
            allSubjects.CollectionChanged += CheckboxChanged;
            InitializeComponent();
            allSubjects = new(DataGetMethods.GetSubjects());
            DataSubjectGrid.ItemsSource = active;
        }
        private void CheckboxChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            DataSubjectGrid.ItemsSource = (CheckboxDeleted?.IsChecked ?? false) ? deleted : active;
              
            DataSubjectGrid.Items.Refresh();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void New(object sender, RoutedEventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Subject Selected = (Subject)DataSubjectGrid.SelectedItem;

            if (Selected != null)
            {
                Selected.IsDeleted = !Selected.IsDeleted;
                DataSubjectGrid.ItemsSource = (CheckboxDeleted?.IsChecked ?? false) ? deleted : active;
                DataSubjectGrid.Items.Refresh();
                DataSetMethods.Update(Selected);

            }
        }

        private void ShowDeleted(object sender, RoutedEventArgs e)
        {
            DataSubjectGrid.ItemsSource = deleted;
            DataSubjectGrid.Items.Refresh();
        }

        private void ShowActive(object sender, RoutedEventArgs e)
        {
            DataSubjectGrid.ItemsSource = active;
            DataSubjectGrid.Items.Refresh();

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            Subject Selected = (Subject)DataSubjectGrid.SelectedItem;

            if (Selected != null)
            {
                AddSubject addSubject = new AddSubject();
                addSubject.Insert(Selected);
                addSubject.ShowDialog();
                DataSubjectGrid.Items.Refresh();
            }
           

        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            DataSubjectGrid.Items.Refresh();
        }
    }
}
