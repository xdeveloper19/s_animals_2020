namespace WebAnimalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mammals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Cover = c.Int(nullable: false),
                        Temperature = c.Double(nullable: false),
                        IsSwimming = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Artiodactylses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Cover = c.Int(nullable: false),
                        Temperature = c.Double(nullable: false),
                        IsSwimming = c.Boolean(nullable: false),
                        IsRum = c.Boolean(nullable: false),
                        Hoofs = c.Int(nullable: false),
                        HornAvailable = c.Boolean(nullable: false),
                        HornLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Birds",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Weight = c.Double(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        IsTalking = c.Boolean(nullable: false),
                        Wings = c.Int(nullable: false),
                        Eggs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Animals", "IsTalking");
            DropColumn("dbo.Animals", "Wings");
            DropColumn("dbo.Animals", "Eggs");
            DropColumn("dbo.Animals", "Cover");
            DropColumn("dbo.Animals", "Temperature");
            DropColumn("dbo.Animals", "IsSwimming");
            DropColumn("dbo.Animals", "IsRum");
            DropColumn("dbo.Animals", "Hoofs");
            DropColumn("dbo.Animals", "HornAvailable");
            DropColumn("dbo.Animals", "HornLength");
            DropColumn("dbo.Animals", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Animals", "HornLength", c => c.Int());
            AddColumn("dbo.Animals", "HornAvailable", c => c.Boolean());
            AddColumn("dbo.Animals", "Hoofs", c => c.Int());
            AddColumn("dbo.Animals", "IsRum", c => c.Boolean());
            AddColumn("dbo.Animals", "IsSwimming", c => c.Boolean());
            AddColumn("dbo.Animals", "Temperature", c => c.Double());
            AddColumn("dbo.Animals", "Cover", c => c.Int());
            AddColumn("dbo.Animals", "Eggs", c => c.Int());
            AddColumn("dbo.Animals", "Wings", c => c.Int());
            AddColumn("dbo.Animals", "IsTalking", c => c.Boolean());
            DropTable("dbo.Birds");
            DropTable("dbo.Artiodactylses");
            DropTable("dbo.Mammals");
        }
    }
}
