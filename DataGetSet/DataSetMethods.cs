using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakázky.DB_Class;

namespace Zakázky.DataGetSet
{
    public static class DataSetMethods

    { 
        public static void SetSubject(string SubjectName, string SubjectCode, int ICO, string DIC)
        {
            using (var SetSubjectInsert = new MainDBContext())
            {
                Subject subject = new Subject();
                subject.SubjectName = SubjectName;
                subject.SubjectCode = SubjectCode;
                subject.ICO = ICO;
                subject.DIC = DIC;
                subject.UpdatedDate = DateTime.Now;
                SetSubjectInsert.Subject.Add(subject);
                SetSubjectInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");
            }

        }
        
        public static void SetContact(string Name, int Phone, string Email)
        {
            using (var SetContactInsert = new MainDBContext())
            {
                ContactList contact = new ContactList();
                contact.Name = Name;
                contact.Phone = Phone;
                contact.Email = Email;
                contact.UpdatedDate = DateTime.Now;
                
                SetContactInsert.ContactList.Add(contact);
                SetContactInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");
            }
         
        }

        public static void SetAdress(string AdressName, string City, string Region, int PostalCode)
        {
            using (var SetAdressInsert = new MainDBContext())
            {
                AdressList Adress = new AdressList();
                Adress.Adress = AdressName;
                Adress.City = City;
                Adress.Region = Region;
                Adress.PostalCode = PostalCode;
                
                SetAdressInsert.AdressList.Add(Adress);
                SetAdressInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");
            }

        }

        public static void SetOrder(string AdressName, string City, string Region, int PostalCode)
        {
            using (var SetAdressInsert = new MainDBContext())
            {
                AdressList Adress = new AdressList();
                Adress.Adress = AdressName;
                Adress.City = City;
                Adress.Region = Region;
                Adress.PostalCode = PostalCode;

                SetAdressInsert.AdressList.Add(Adress);
                SetAdressInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");
            }

        }

    }
}
