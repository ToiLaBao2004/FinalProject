namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ImportDetails", "TotalOfProduct", c => c.Int());
            AlterColumn("dbo.Customers", "Gender", c => c.String(nullable: false, maxLength: 3, fixedLength: true));
            AlterColumn("dbo.Employees", "Gender", c => c.String(nullable: false, maxLength: 3, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Gender", c => c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false));
            AlterColumn("dbo.Customers", "Gender", c => c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false));
            AlterColumn("dbo.ImportDetails", "TotalOfProduct", c => c.Int());
        }
    }
}
