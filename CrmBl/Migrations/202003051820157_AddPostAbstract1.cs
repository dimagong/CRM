namespace CrmBl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostAbstract1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Created", c => c.DateTime(nullable: false));
        }
    }
}
