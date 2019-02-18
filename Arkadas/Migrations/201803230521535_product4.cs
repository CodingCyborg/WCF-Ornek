namespace Arkadas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product4 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ProductDetails", "ProductId");
            AddForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
        }
    }
}
