using System;
using System.Collections.Generic;
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
                var orders = dataOrder.Order.ToList();
                return orders;
            }

        }

        public static List<Subject> GetSubjects()
        {
            using (var dataSubjects = new MainDBContext())
            {
                var subjects = dataSubjects.Subject.ToList();
                return subjects;
            }

        }
    }
}
