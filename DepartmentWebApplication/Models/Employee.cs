using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DepartmentWebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }
         
        public int Age { get; set; }

        public int Salary { get; set; }
        [ForeignKey("TypeOfDepartmentcs")]
        public int  DepartmentID { get; set; }

        public TypeOfDepartmentcs TypeOfDepartmentcs { get; set; }
    }
}