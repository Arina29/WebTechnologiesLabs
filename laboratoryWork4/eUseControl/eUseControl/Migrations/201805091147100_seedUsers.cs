namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'987642d3-efa1-48bf-80b3-72b1e52f8f5f', N'user@design.com', 0, N'AIzpSkVDN4vHUHEXtTAXK0ES4IxzN80EqfVqSndIPuL4G9v+0wxPvFBXujc8HdfUVg==', N'90e193d6-63ec-4269-85aa-a435559c6d8d', NULL, 0, 0, NULL, 1, 0, N'user@design.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ce03ab0e-f11f-407f-b553-c110bf67d395', N'administrator@design.com', 0, N'ABCiZXQjYTsf5cK0lfL416pecJXOv3Gle7MLm0Zn2PEiT5BI1XYjeB218aQtB61KIg==', N'c7a08890-a98e-4ff1-abe2-030205e47c27', NULL, 0, 0, NULL, 1, 0, N'administrator@design.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71d3a7fd-494d-4e37-b79b-291822d38df8', N'admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ce03ab0e-f11f-407f-b553-c110bf67d395', N'71d3a7fd-494d-4e37-b79b-291822d38df8')

");
        }
        
        public override void Down()
        {
        }
    }
}
