namespace RIABooks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 25),
                        LastName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
        }
    }
}
