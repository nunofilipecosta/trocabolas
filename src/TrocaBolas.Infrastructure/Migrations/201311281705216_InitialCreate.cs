namespace TrocaBolas.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrocaBolasUserProfiles",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 500),
                        ZipCode = c.String(nullable: false, maxLength: 8),
                        Address = c.String(nullable: false, maxLength: 500),
                        Town = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrocaBolasUserProfiles");
        }
    }
}
