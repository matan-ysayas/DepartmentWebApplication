using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentWebApplication.Models
{
    public class TypeOfDepartmentcs
    {
        public int Id { get; set; }
        public string NameOfDepartment{ get; set; }

        public string TypeOfWork { get; set; }

        public int NumberOfEmployee { get; set; }
    }
}