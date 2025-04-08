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
        public string? ICO { get; set; }
        public string? DIC { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }




  
    

}
