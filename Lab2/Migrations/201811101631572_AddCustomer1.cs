namespace Lab2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Unitprice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Unitprice");
        }
    }
}
