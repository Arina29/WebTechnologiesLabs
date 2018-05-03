namespace eUseControl.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.userInfoes", "StyleTypesId", c => c.Int(nullable: false));
            CreateIndex("dbo.userInfoes", "StyleTypesId");
            AddForeignKey("dbo.userInfoes", "StyleTypesId", "dbo.StyleTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.userInfoes", "StyleTypesId", "dbo.StyleTypes");
            DropIndex("dbo.userInfoes", new[] { "StyleTypesId" });
            DropColumn("dbo.userInfoes", "StyleTypesId");
        }
    }
}
