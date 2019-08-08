namespace Lawyer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalCase = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalClient = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        EvaluationUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Laws",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Question = c.String(),
                        Answere = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NavSectionBrands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LogoImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PracticeAreas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrimaryHeading = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SliderSections",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WelcomeTitle = c.String(),
                        HeadingTitle = c.String(),
                        ShortDescription = c.String(),
                        SpanImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Socials",
                c => new
                    {
                        SocialId = c.Int(nullable: false, identity: true),
                        FacebookUrl = c.String(),
                        TwitterUrl = c.String(),
                        SkypeUrl = c.String(),
                        YoutubeUrl = c.String(),
                        LinkedInUrl = c.String(),
                    })
                .PrimaryKey(t => t.SocialId);
            
            CreateTable(
                "dbo.TeamPersons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(),
                        Category = c.String(),
                        Description = c.String(),
                        FacebookUrl = c.String(),
                        TwitterUrl = c.String(),
                        InstagramUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WhyChooseUs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PrimaryTitle = c.String(),
                        Subtitle = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WhyChooseUs");
            DropTable("dbo.Testimonials");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamPersons");
            DropTable("dbo.Socials");
            DropTable("dbo.SliderSections");
            DropTable("dbo.Services");
            DropTable("dbo.PracticeAreas");
            DropTable("dbo.NavSectionBrands");
            DropTable("dbo.Laws");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
            DropTable("dbo.Cases");
        }
    }
}
