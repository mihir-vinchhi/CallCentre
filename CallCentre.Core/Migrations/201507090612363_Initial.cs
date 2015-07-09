using System.Data.Entity.Migrations;

namespace CallCentre.Core.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operators",
                c =>
                    new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Extension = c.Int(nullable: false),
                        CallStatus = c.Int(nullable: false)
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Extension, unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Operators", new[] { "Extension" });
            DropTable("dbo.Operators");
        }
    }
}
