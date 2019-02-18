namespace Arkadas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
            CreateIndex("dbo.ProductDetails", "ProductId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
            CreateIndex("dbo.ProductDetails", "ProductId");
        }
    }
}
