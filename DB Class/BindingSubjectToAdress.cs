using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class
{
    public class BindingSubjectToAdress
    {
        public int ID { get; set; }
        public int? SubjectId { get; set; }
        public int? AdressId { get; set; }  
    }
}
