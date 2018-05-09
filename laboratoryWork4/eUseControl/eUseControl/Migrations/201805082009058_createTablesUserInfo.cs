namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTablesUserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StyleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StyleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.userInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        phoneNumber = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 100),
                        StyleTypesId = c.Int(nullable: false),
                        PicturePath = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StyleTypes", t => t.StyleTypesId, cascadeDelete: true)
                .Index(t => t.StyleTypesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.userInfoes", "StyleTypesId", "dbo.StyleTypes");
            DropIndex("dbo.userInfoes", new[] { "StyleTypesId" });
            DropTable("dbo.userInfoes");
            DropTable("dbo.StyleTypes");
        }
    }
}
