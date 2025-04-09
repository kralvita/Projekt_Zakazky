using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class
{
    public class OrderItem
    {
        public int ID { get; set; }
        public string? OrderItemName { get; set; }
        public string? OrderItemNote { get; set; }
        public string? OrderItemQuantity { get; set; }
        public int? OrderID { get; set; }
        public required Order Order { get; set; }
        Boolean IsDeleted { get; set; } = false;    
    }
}
