namespace CrmBl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostAbstract : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentRates",
                c => new
                    {
                        CurrentRateId = c.Int(nullable: false, identity: true),
                        NameCurrent = c.String(),
                        CodeCurrent = c.String(),
                        CurrentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataCurrentUpdate = c.String(),
                    })
                .PrimaryKey(t => t.CurrentRateId);
            
            AddColumn("dbo.Products", "CurrentRateId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CurrentValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Products", "CurrentRateId");
            AddForeignKey("dbo.Products", "CurrentRateId", "dbo.CurrentRates", "CurrentRateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CurrentRateId", "dbo.CurrentRates");
            DropIndex("dbo.Products", new[] { "CurrentRateId" });
            DropColumn("dbo.Products", "CurrentValue");
            DropColumn("dbo.Products", "CurrentRateId");
            DropTable("dbo.CurrentRates");
        }
    }
}
