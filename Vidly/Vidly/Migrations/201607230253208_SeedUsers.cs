namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a3a270db-8da7-45c1-a25d-21e96a71a1d9', N'guest@vidly.com', 0, N'AHNpuxvZhecHVBxut1RL9bg5SnMLiN+0IpEmU2v4tkuePnkvCvrVByfGBuMhvGSlRA==', N'79c853a1-4c2a-4a16-b3aa-a880ee9fc203', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b185e8ef-c046-4e43-8c2c-490c80f5affb', N'admin@vidly.com', 0, N'ALLU6f4lIkNkQdG5FeY51gRe/Eg2CjUz7hIP7aEo/JAGOVPFRujbw5MzYYBvdRl01A==', N'c8bc1baa-2a29-46ed-8ad0-a1a6e77dd272', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ed6738bf-58e7-442c-8a98-3c81a8c570d6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b185e8ef-c046-4e43-8c2c-490c80f5affb', N'ed6738bf-58e7-442c-8a98-3c81a8c570d6')
");
        }
        
        public override void Down()
        {
        }
    }
}
