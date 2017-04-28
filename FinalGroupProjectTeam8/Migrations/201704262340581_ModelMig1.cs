namespace FinalGroupProjectTeam8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelMig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankUsers",
                c => new
                    {
                        BankUserID = c.String(nullable: false, maxLength: 128),
                        UserType = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleInitial = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Street = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        Zip = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BankUserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BankUsers");
        }
    }
}
