namespace AquariumLINQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLifes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        Name = c.String(),
                        DateAddedToTank = c.DateTime(),
                        IsInQuarantee = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AquaticLifes");
        }
    }
}
