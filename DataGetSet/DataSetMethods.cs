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
        public static void SetAdress(string adressname, string adress, string City, string Region, int PostalCode)
        {
            using (var SetAdressInsert = new MainDBContext())
            {
                AdressList Adress = new AdressList();
                Adress.AdressName = adressname;
                Adress.Adress = adress;
                Adress.City = City;
                Adress.Region = Region;
                Adress.PostalCode = PostalCode;
                
                SetAdressInsert.AdressList.Add(Adress);
                SetAdressInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");
            }

        }
        public static void SetOrder(DateTime Date, string Name, OrderType Type, OrderState State, string description, string note, int customerID, decimal etc, decimal tc)
        {
            using (var SetOrderInsert = new MainDBContext())
            {
                Order order = new();
                order.OrderDate = Date;
                order.OrderName = Name;
                order.orderType = Type;
                order.orderState = State;
                order.OrderDescription = description;
                order.OrderNote = note;
                order.EstimatedTotalCost = etc;
                order.EstimatedTotalCost = tc;  
                order.CustumerID = customerID;
                SetOrderInsert.Order.Add(order);
                SetOrderInsert.SaveChanges();
                System.Windows.MessageBox.Show("Uloženo!");

            }

        }

        public static void Update(Subject s)
        {
            using (var Update = new MainDBContext())
            {
                Update.Subject.Update(s);
                Update.SaveChanges();
            }
        }
        public static void Update(Order s)
        {
            using (var Update = new MainDBContext())
            {
                Update.Order.Update(s);
                Update.SaveChanges();
            }
        }
        public static void Update(OrderItem s)
        {
            using (var Update = new MainDBContext())
            {
                Update.OrderItem.Update(s);
                Update.SaveChanges();
            }
        }
        public static void Update(AdressList s)
        {
            using (var Update = new MainDBContext())
            {
                Update.AdressList.Update(s);
                Update.SaveChanges();
            }
        }
        public static void Update(ContactList s)
        {
            using (var Update = new MainDBContext())
            {
                Update.ContactList.Update(s);
                Update.SaveChanges();
            }
        }
    }
}
