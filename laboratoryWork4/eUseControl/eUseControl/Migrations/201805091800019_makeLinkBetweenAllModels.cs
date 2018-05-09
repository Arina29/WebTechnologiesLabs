namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeLinkBetweenAllModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.userInfoes", "profileId", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.userInfoes", "profileId");
        }
    }
}
