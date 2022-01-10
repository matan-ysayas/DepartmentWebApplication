using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DepartmentWebApplication.Models
{
    public partial class Department : DbContext
    {
        public Department()
            : base("name=DepartmentDB")
        {
        }
        public virtual DbSet<TypeOfDepartmentcs> TypeOfDepartmentcs { get; set; }
       public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
