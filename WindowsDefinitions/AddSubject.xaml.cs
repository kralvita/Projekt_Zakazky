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

        private void Save(object sender, RoutedEventArgs e)
        {
            string Name = SName.Text;
            string Shortcut = zkratka.Text;
            int Ico = Convert.ToInt32(ico_num.Text);
            string DIC = dic.Text;

            DataSetMethods.SetSubject(Name, Shortcut, Ico, DIC);

            SName.Text = string.Empty;
            zkratka.Text = string.Empty;
            ico_num.Text = string.Empty;
            dic.Text = string.Empty;

        }
    }
}
