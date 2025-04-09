using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakázky.DB_Class;

namespace Zakázky.DataGetSet
{
    public class DataSetMethods

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
                Console.WriteLine("Nový subjekt uložen");
            }

        }
        
        public static void SetContact(string Name, int Phone, string Email,int SubjectID)
        {
            using (var SetContactInsert = new MainDBContext())
            {
                ContactList contact = new ContactList();
                contact.Name = Name;
                contact.Phone = Phone;
                contact.Email = Email;
                contact.UpdatedDate = DateTime.Now;
                contact.SubjectID  = SubjectID;

                SetContactInsert.ContactList.Add(contact);
                SetContactInsert.SaveChanges();
                Console.WriteLine(Name + " - Kontakt byl uložen");
            }
         
        }

        public static void SetAdress(string AdressName, string City, string Region, int PostalCode, int SubjectID)
        {
            using (var SetAdressInsert = new MainDBContext())
            {
                AdressList Adress = new AdressList();
                Adress.Adress = AdressName;
                Adress.City = City;
                Adress.Region = Region;
                Adress.PostalCode = PostalCode;
                Adress.SubjectID = SubjectID;

                SetAdressInsert.AdressList.Add(Adress);
                SetAdressInsert.SaveChanges();
                Console.WriteLine(AdressName + " - Adresa byla uložena");
            }

        }


    }
}
