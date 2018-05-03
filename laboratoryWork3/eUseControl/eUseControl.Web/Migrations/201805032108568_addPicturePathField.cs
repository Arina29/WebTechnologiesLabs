namespace eUseControl.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPicturePathField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.userInfoes", "PicturePath", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.userInfoes", "PicturePath");
        }
    }
}
