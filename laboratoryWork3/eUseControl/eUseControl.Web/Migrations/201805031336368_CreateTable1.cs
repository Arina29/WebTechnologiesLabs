namespace eUseControl.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable1 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StyleTypes");
        }
    }
}
