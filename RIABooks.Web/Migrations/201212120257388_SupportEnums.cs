namespace RIABooks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupportEnums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookType", c => c.Int(nullable: false, defaultValue: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "BookType");
        }
    }
}
