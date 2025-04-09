using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class
{
    public class ContactList
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public int? SubjectID { get; set; }
        public Subject? Subject { get; set; }

    }
}
