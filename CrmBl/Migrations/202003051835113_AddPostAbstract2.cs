namespace CrmBl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostAbstract2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CurrentRateId", "dbo.CurrentRates");
            DropForeignKey("dbo.Products", "WerehouseId", "dbo.Werehouses");
            DropIndex("dbo.Products", new[] { "WerehouseId" });
            DropIndex("dbo.Products", new[] { "CurrentRateId" });
            AddColumn("dbo.Products", "Created", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "WerehouseId");
            DropColumn("dbo.Products", "CurrentRateId");
            DropColumn("dbo.Products", "CurrentValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CurrentValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "CurrentRateId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "WerehouseId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Created");
            CreateIndex("dbo.Products", "CurrentRateId");
            CreateIndex("dbo.Products", "WerehouseId");
            AddForeignKey("dbo.Products", "WerehouseId", "dbo.Werehouses", "WerehouseId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CurrentRateId", "dbo.CurrentRates", "CurrentRateId", cascadeDelete: true);
        }
    }
}
