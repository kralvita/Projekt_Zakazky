using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Zakázky.WindowsDefinitions
{
    /// <summary>
    /// Interakční logika pro AddAdress.xaml
    /// </summary>
    public partial class AddAdress : Window

    {
        private bool Validation()
        {

            if (string.IsNullOrWhiteSpace(AdressName.Text))
            {
                System.Windows.MessageBox.Show("Pole 'Název' je povinné.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Adress.Text))
            {
                System.Windows.MessageBox.Show("Pole 'Adresa' je povinné.");
                return false;
            }
            if (!int.TryParse(PostalCode.Text, out _))
            {
                System.Windows.MessageBox.Show("Pole 'PSČ' musí být číslo.");
                return false;
            }
            return true;
        }


        public AddAdress()
        {
            InitializeComponent();
        }

        private void SaveAdress(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            return;

            string adressname = AdressName.Text;
            string adress = Adress.Text;
            string city = City.Text;
            string region = Region.Text;
            int Ico = Convert.ToInt32(PostalCode.Text);
            DataSetMethods.SetAdress(adressname,adress,city,region,Ico);
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

                
    }
}
