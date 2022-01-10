namespace DepartmentWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateTypeOfDepartmentcs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeOfDepartmentcs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfDepartment = c.String(),
                        TypeOfWork = c.String(),
                        NumberOfEmployee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeOfDepartmentcs");
        }
    }
}
