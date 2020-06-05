namespace InfraestructureConcrete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Extension", c => c.String());
            AlterColumn("dbo.Orders", "OrderNumber", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Orders", "OrderNumber", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Customers", "Extension");
        }
    }
}
