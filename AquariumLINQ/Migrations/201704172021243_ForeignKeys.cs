namespace AquariumLINQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aquariums", "AquariumAquaticLifeId", c => c.Int());
            AddColumn("dbo.Oceans", "AquariumAquaticLifeId", c => c.Int());
            CreateIndex("dbo.Aquariums", "AquariumAquaticLifeId");
            CreateIndex("dbo.Oceans", "AquariumAquaticLifeId");
            AddForeignKey("dbo.Aquariums", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives", "Id");
            AddForeignKey("dbo.Oceans", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Oceans", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives");
            DropForeignKey("dbo.Aquariums", "AquariumAquaticLifeId", "dbo.AquariumAquaticLives");
            DropIndex("dbo.Oceans", new[] { "AquariumAquaticLifeId" });
            DropIndex("dbo.Aquariums", new[] { "AquariumAquaticLifeId" });
            DropColumn("dbo.Oceans", "AquariumAquaticLifeId");
            DropColumn("dbo.Aquariums", "AquariumAquaticLifeId");
        }
    }
}
