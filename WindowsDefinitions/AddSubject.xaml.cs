using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using System.Text.RegularExpressions;
using Zakázky.DataGetSet;
using Microsoft.Identity.Client;
using Zakázky.DB_Class;

namespace Zakázky.WindowsDefinitions
{
    /// <summary>
    /// Interakční logika pro AddSubject.xaml
    /// </summary>
    public partial class AddSubject : Window
    {
        private string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private bool editingmode = false;
        public Subject ESuject = new();
        public void Insert (Subject subject)
        {
            editingmode = true;
            ESuject=subject;
            SName.Text = subject.SubjectName;
            SCode.Text = subject.SubjectCode;
            SICO.Text = Convert.ToString(subject.ICO);
            SDIC.Text = subject.DIC;

        }
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

            if (!int.TryParse(SICO.Text, out _))
            {
                System.Windows.MessageBox.Show("Pole 'IČO' musí být číslo.");
                return false;
            }

            if(Regex.IsMatch(SEmail.Text,pattern))
            {
                return false;
            }
            return true;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            if (!Validation())
                return;

            string Name = SName.Text;
            string Shortcut = SCode.Text;
            int Ico = Convert.ToInt32(SICO.Text);
            string DIC = SDIC.Text;

            //Kontatní údaje subjektu
            string email = SEmail.Text;
            if (!editingmode) {
                DataSetMethods.SetSubject(Name, Shortcut, Ico, DIC);
            }
            else
            {
                ESuject.SubjectName = SName.Text;
                ESuject.SubjectCode = SCode.Text;
                ESuject.ICO = Convert.ToInt32(SICO.Text);
                ESuject.DIC = SDIC.Text;
                DataSetMethods.Update(ESuject);
                this.Close();
            }
                /*Vymazání proměnných v okně*/
                SName.Clear();
                SCode.Clear();
                SICO.Clear();
                SDIC.Clear();           
            

        }
       
        private void Close(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void DeleteAdress(object sender, RoutedEventArgs e)
        {

        }

        private void NewAdress(object sender, RoutedEventArgs e)
        {
            AddAdress AddAdressWindow = new AddAdress();
            AddAdressWindow.ShowDialog();
        }
    }
}
