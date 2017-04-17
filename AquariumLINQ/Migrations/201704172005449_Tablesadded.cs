namespace AquariumLINQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablesadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aquariums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AquariumAquaticLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Oceans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AverageTemperature = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AquaticLifes", "AquariumAquaticLifeId", c => c.Int());
            CreateIndex("dbo.AquaticLifes", "AquariumAquaticLifeId");
            AddForeignKey("dbo.AquaticLifes", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquaticLifes", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives");
            DropIndex("dbo.AquaticLifes", new[] { "AquariumAquaticLifeId" });
            DropColumn("dbo.AquaticLifes", "AquariumAquaticLifeId");
            DropTable("dbo.Oceans");
            DropTable("dbo.AquariumAquaticLives");
            DropTable("dbo.Aquariums");
        }
    }
}
