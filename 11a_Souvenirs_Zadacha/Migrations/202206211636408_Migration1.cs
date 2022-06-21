namespace _11a_Souvenirs_Zadacha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Souvenirs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SouvenirTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SouvenirTypes", t => t.SouvenirTypeId, cascadeDelete: true)
                .Index(t => t.SouvenirTypeId);
            
            CreateTable(
                "dbo.SouvenirTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Souvenirs", "SouvenirTypeId", "dbo.SouvenirTypes");
            DropIndex("dbo.Souvenirs", new[] { "SouvenirTypeId" });
            DropTable("dbo.SouvenirTypes");
            DropTable("dbo.Souvenirs");
        }
    }
}
