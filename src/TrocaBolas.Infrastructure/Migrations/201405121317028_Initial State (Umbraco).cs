namespace TrocaBolas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialStateUmbraco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductTypeId = c.Int(nullable: false),
                        ProductOwnerId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ProductState = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Visualizations = c.Int(nullable: false),
                        Size = c.String(),
                        Color = c.String(),
                        PreservationState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductTypeId", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypeId" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
