namespace Arkadas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDetails", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductDetails", "ImageUrl");
        }
    }
}
