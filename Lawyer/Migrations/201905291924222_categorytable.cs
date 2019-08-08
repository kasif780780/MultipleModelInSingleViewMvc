namespace Lawyer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryTitle = c.String(),
                        CatDescription = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
