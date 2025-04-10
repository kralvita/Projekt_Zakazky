using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakázky.DB_Class
{
    public class Employee
    {
        public int Id { get; set; }
        public string? EmployeeFullName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ContactId { get; set; }
        public ContactList? Contact { get; set; }
        public Boolean IsDeleted { get; set; } = false;    

    }
}
