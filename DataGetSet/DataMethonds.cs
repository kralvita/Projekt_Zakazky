using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakázky.DB_Class;

namespace Zakázky.DataGetSet
{
    public class DataMethonds

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


                /*SetSubjectInsert.Subject.Add(subject);
                SetSubjectInsert.SaveChanges();*/

            }

        }
        /*
        public static void SetContact(string Name, int Phone, string Email, DateTime CreatedDate,Subject Subject,DateTime UpdatedDate)
        {
            using (var SetContactInsert = new MainDBContext())
            {
                ContactList Contact = new ContactList();
                Contact.Name = Name;
                Contact.Phone = Phone;
                Contact.Email = Email;
                Contact.CreatedDate = DateTime.Now;
                Contact.Subject = Subject;
            }
         
        }
        */

    }
}
