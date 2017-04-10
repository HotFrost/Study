namespace Books.Web.AceDataContext.BooksMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrltoBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Url");
        }
    }
}
