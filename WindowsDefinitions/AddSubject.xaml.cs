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
    /// Interakční logika pro AddSubject.xaml
    /// </summary>
    public partial class AddSubject : Window
    {
        public AddSubject()
        {
            InitializeComponent();                   

        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(SName.Text))
            {
                System.Windows.MessageBox.Show("Pole 'Název' je povinné.");
                return false;
            }

            if (!int.TryParse(ico_num.Text, out _))
            {
                System.Windows.MessageBox.Show("Pole 'IČO' musí být číslo.");
                return false;
            }
            return true;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            if (!Validation())
                return;
                string Name = SName.Text;
                string Shortcut = zkratka.Text;
                int Ico = Convert.ToInt32(ico_num.Text);
                string DIC = dic.Text;
                DataSetMethods.SetSubject(Name, Shortcut, Ico, DIC);
                /*Vymazání proměnných v okně*/
                SName.Clear();
                zkratka.Clear();
                ico_num.Clear();
                dic.Clear();           
            

        }

        private void Close(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
