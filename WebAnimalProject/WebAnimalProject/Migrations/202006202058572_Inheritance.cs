namespace WebAnimalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        IsTalking = c.Boolean(),
                        Wings = c.Int(),
                        Eggs = c.Int(),
                        Cover = c.Int(),
                        Temperature = c.Double(),
                        IsSwimming = c.Boolean(),
                        IsRum = c.Boolean(),
                        Hoofs = c.Int(),
                        HornAvailable = c.Boolean(),
                        HornLength = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
