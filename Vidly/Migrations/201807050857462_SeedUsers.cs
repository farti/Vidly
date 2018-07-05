namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4d1ec356-8aff-4873-bf47-732ca50d3848', N'guest@vidly.com', 0, N'AIpIZabwYHy1oKCgAsMzPjnRRiLAbfAQMn3OhLkYXM+9hSCtPfU1NGkrVdCGmgJESw==', N'1061d21f-9a90-4d8d-a6f4-9baff087bc00', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e8ecd3b-7f4b-4674-adac-76ffa0893829', N'admin@vidly.com', 0, N'AOP/b+KBaWkZ+0enEurlqKJZMnyGjcs0q0GArj9vpi66xBOP2MtzW1yHuFTQ9CDuhg==', N'1847bcf6-8308-4dbf-ae09-7972f3d43f6f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aa58bee2-61c3-4c49-bc9a-b707d311acca', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5e8ecd3b-7f4b-4674-adac-76ffa0893829', N'aa58bee2-61c3-4c49-bc9a-b707d311acca')
");

        }
        
        public override void Down()
        {
        }
    }
}
