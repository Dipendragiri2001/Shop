namespace MyShop.DataAccess.Sql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedordermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Street", c => c.String());
            DropColumn("dbo.Orders", "String");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "String", c => c.String());
            DropColumn("dbo.Orders", "Street");
        }
    }
}
