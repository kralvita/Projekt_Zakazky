using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class
{
    public class AdressList
    {
        public int ID { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }  
        public string? Region { get; set; }
        public int? PostalCode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public Boolean IsDeleted { get; set; } = false;


    }
}
