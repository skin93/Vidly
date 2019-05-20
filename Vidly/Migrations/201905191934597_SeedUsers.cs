namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6107c7c4-1ee5-4df0-9393-bc513b6b7f16', N'admin@vidly.com', 0, N'AELm2TuEMoh9DOwJYtAl/XnBu641XOaiRLRX0x/ZYszCCsi02Q0zjWfv3+6m+HB8Iw==', N'97ccd792-9773-4177-b996-14831182b3e1', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7456890f-8cb1-45c2-9f1a-819878a7832d', N'arro.ciesielski@gmail.com', 0, N'AKTY18CbGyclTcYINdpIqF44l9L8TRA6jKq9B+kHFxPX+g+h7nT+A5vggJVU0U/skA==', N'e41e480d-e621-4177-a983-1f91b51ef3b3', NULL, 0, 0, NULL, 1, 0, N'arro.ciesielski@gmail.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df5071b3-f927-4511-96bb-fbf64877ac3f', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6107c7c4-1ee5-4df0-9393-bc513b6b7f16', N'df5071b3-f927-4511-96bb-fbf64877ac3f')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
