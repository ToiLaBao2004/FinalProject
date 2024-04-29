namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                {
                    Brand_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    BrandName = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Brand_ID);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    Product_ID = c.String(nullable: false, maxLength: 15, unicode: false),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    UnitPrice = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    Brand_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    Category_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    Picture_ID = c.Int(),
                })
                .PrimaryKey(t => t.Product_ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.PictureProducts", t => t.Picture_ID)
                .ForeignKey("dbo.Brands", t => t.Brand_ID)
                .Index(t => t.Brand_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.Picture_ID);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Category_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    CategoryName = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Category_ID);

            CreateTable(
                "dbo.ImportDetails",
                c => new
                {
                    Import_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    Product_ID = c.String(nullable: false, maxLength: 15, unicode: false),
                    Quantity = c.Int(nullable: false),
                    Unitcost = c.Int(nullable: false),
                    TotalOfProduct = c.Int(),
                })
                .PrimaryKey(t => new { t.Import_ID, t.Product_ID })
                .ForeignKey("dbo.Imports", t => t.Import_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Import_ID)
                .Index(t => t.Product_ID);

            CreateTable(
                "dbo.Imports",
                c => new
                {
                    Import_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    Supplier_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    ImportDay = c.DateTime(nullable: false, storeType: "date"),
                    TotalMoney = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Import_ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .Index(t => t.Supplier_ID);

            CreateTable(
                "dbo.Suppliers",
                c => new
                {
                    Supplier_ID = c.String(nullable: false, maxLength: 10, unicode: false),
                    CompanyName = c.String(nullable: false, maxLength: 30),
                    PhoneNumber = c.String(maxLength: 12, unicode: false),
                    AddressSupplier = c.String(nullable: false, maxLength: 100),
                    Email = c.String(maxLength: 50, unicode: false),
                })
                .PrimaryKey(t => t.Supplier_ID);

            CreateTable(
                "dbo.OrderDetails",
                c => new
                {
                    Order_ID = c.String(nullable: false, maxLength: 15, unicode: false),
                    Product_ID = c.String(nullable: false, maxLength: 15, unicode: false),
                    Quantity = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Order_ID, t.Product_ID })
                .ForeignKey("dbo.Orders", t => t.Order_ID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Order_ID)
                .Index(t => t.Product_ID);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    Order_ID = c.String(nullable: false, maxLength: 15, unicode: false),
                    Customers_ID = c.String(nullable: false, maxLength: 7, unicode: false),
                    Employee_ID = c.String(nullable: false, maxLength: 5, unicode: false),
                    OrderDate = c.DateTime(nullable: false, storeType: "date"),
                    TotalMoney = c.Int(nullable: false),
                    DiscountCode = c.String(maxLength: 10, unicode: false),
                })
                .PrimaryKey(t => t.Order_ID)
                .ForeignKey("dbo.Customers", t => t.Customers_ID)
                .ForeignKey("dbo.Discounts", t => t.DiscountCode)
                .ForeignKey("dbo.Employees", t => t.Employee_ID)
                .Index(t => t.Customers_ID)
                .Index(t => t.Employee_ID)
                .Index(t => t.DiscountCode);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    Customers_ID = c.String(nullable: false, maxLength: 7, unicode: false),
                    PhoneNumber = c.String(maxLength: 12, unicode: false),
                    NameCustomer = c.String(nullable: false, maxLength: 50),
                    Birthday = c.DateTime(storeType: "date"),
                    Gender = c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false),
                    AddressCustomer = c.String(maxLength: 100),
                    TotalMoney = c.Int(),
                })
                .PrimaryKey(t => t.Customers_ID);

            CreateTable(
                "dbo.Discounts",
                c => new
                {
                    DiscountCode = c.String(nullable: false, maxLength: 10, unicode: false),
                    PercentageDiscount = c.Int(nullable: false),
                    StartDay = c.DateTime(nullable: false, storeType: "date"),
                    EndDay = c.DateTime(nullable: false, storeType: "date"),
                })
                .PrimaryKey(t => t.DiscountCode);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    Employee_ID = c.String(nullable: false, maxLength: 5, unicode: false),
                    NameEmployee = c.String(nullable: false, maxLength: 50),
                    Birthday = c.DateTime(storeType: "date"),
                    Gender = c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false),
                    AddressEmployee = c.String(nullable: false, maxLength: 100),
                    PhoneNumber = c.String(nullable: false, maxLength: 12, unicode: false),
                    RoleEmployee = c.String(nullable: false, maxLength: 50),
                    Active = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    PassWordAccount = c.String(nullable: false, maxLength: 16, unicode: false),
                })
                .PrimaryKey(t => t.Employee_ID);

            CreateTable(
                "dbo.PictureProducts",
                c => new
                {
                    Picture_ID = c.Int(nullable: false, identity: true),
                    PictureName = c.String(maxLength: 100, unicode: false),
                })
                .PrimaryKey(t => t.Picture_ID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "Brand_ID", "dbo.Brands");
            DropForeignKey("dbo.Products", "Picture_ID", "dbo.PictureProducts");
            DropForeignKey("dbo.OrderDetails", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.Orders", "DiscountCode", "dbo.Discounts");
            DropForeignKey("dbo.Orders", "Customers_ID", "dbo.Customers");
            DropForeignKey("dbo.ImportDetails", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Imports", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.ImportDetails", "Import_ID", "dbo.Imports");
            DropForeignKey("dbo.Products", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "DiscountCode" });
            DropIndex("dbo.Orders", new[] { "Employee_ID" });
            DropIndex("dbo.Orders", new[] { "Customers_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Product_ID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_ID" });
            DropIndex("dbo.Imports", new[] { "Supplier_ID" });
            DropIndex("dbo.ImportDetails", new[] { "Product_ID" });
            DropIndex("dbo.ImportDetails", new[] { "Import_ID" });
            DropIndex("dbo.Products", new[] { "Picture_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.Products", new[] { "Brand_ID" });
            DropTable("dbo.PictureProducts");
            DropTable("dbo.Employees");
            DropTable("dbo.Discounts");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Imports");
            DropTable("dbo.ImportDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
