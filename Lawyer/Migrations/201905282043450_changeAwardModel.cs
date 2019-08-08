namespace Lawyer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAwardModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Awards", "Awards", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Awards", "Awards", c => c.String());
        }
    }
}
