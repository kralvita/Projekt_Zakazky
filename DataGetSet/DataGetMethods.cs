using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakázky.DB_Class;

namespace Zakázky.DataGetSet
{
    public static class DataGetMethods
    {

        public static List<Order> GetOrders()
        {
            using (var dataOrder = new MainDBContext())
            {
                var orders = dataOrder.Order.Select(s => new Order
                {
                    ID = s.ID,
                    OrderDate = s.OrderDate,
                    OrderName = s.OrderName,
                    orderType = s.orderType,
                    orderState = s.orderState, 
                    OrderDescription = s.OrderDescription,
                    OrderNote = s.OrderNote,
                    EmployeeTookOverID = s.EmployeeTookOverID,
                    CustumerID = s.CustumerID,
                    ContractorID = s.ContractorID,
                    OrderItemID = s.OrderItemID,
                    EstimatedTotalCost = s.EstimatedTotalCost,
                    TotalCost = s.TotalCost,
                    CreatedDate = s.CreatedDate,
                    IsDeleted = s.IsDeleted,   
                }).ToList();
                return orders;
            }

        }
        public static List<OrderItem> GetOrderItems()
        {
            using (var dataOrderItems = new MainDBContext())
            {
                var orderitems = dataOrderItems.OrderItem.Select(s => new OrderItem
                {
                    ID= s.ID,
                    OrderItemName = s.OrderItemName,
                    OrderItemNote = s.OrderItemNote,
                    OrderItemQuantity = s.OrderItemQuantity,
                    IsDeleted = s.IsDeleted,
                }).ToList();
                return orderitems;
            }

        }

        public static List<Subject> GetSubjects()
        {
            
            using (var dataSubjects = new MainDBContext())

            {
                var subjects = dataSubjects.Subject.Select(s=> new Subject
                {
                    ID = s.ID,
                    SubjectName = s.SubjectName,
                    SubjectCode = s.SubjectCode,
                    ICO = s.ICO,
                    DIC = s.DIC,
                    AdressListID = s.AdressListID,
                    ContactListID = s.ContactListID,
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate
                }).ToList();
                return subjects;
            }

        }

        public static List<ContactList> GetContacs()
        {
            using (var dataContacts = new MainDBContext())
            {
                var contacts = dataContacts.ContactList.Select(s => new ContactList
                {
                    ID = s.ID,
                    Name = s.Name,
                    Phone = s.Phone,   
                    Email = s.Email,    
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate
                }).ToList();
                return contacts;
            }

        }
        public static List<AdressList> GetAdress()
        {
            using (var dataAdress = new MainDBContext())
            {
                var adress = dataAdress.AdressList.Select(s => new AdressList
                {
                    ID = s.ID,
                    Adress = s.Adress,
                    City = s.City,
                    Region = s.Region,
                    PostalCode = s.PostalCode,
                    IsDeleted = s.IsDeleted,
                    CreatedDate = s.CreatedDate
                }).ToList();
                return adress;
            }

        }
  
    }
}
