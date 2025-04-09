using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class;

public class Subject
{        
        public int ID { get; set; }        
        public string? SubjectName { get; set; }
        public string? SubjectCode { get; set; }
        public int? ICO { get; set; }
        public string? DIC { get; set; }
        /*public int? AdressListID { get; set; }*/
        public AdressList? Adress { get; set; }
        /*public int? ContactListID { get; set; }*/
        public ContactList? Contact { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        Boolean IsDeleted { get; set; } = false;




  
    

}
