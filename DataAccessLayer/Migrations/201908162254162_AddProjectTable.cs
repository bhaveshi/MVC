namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectNumber = c.String(),
                        ProjectName = c.String(),
                        SupplementNumber = c.Int(nullable: false),
                        SequenceNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            Sql("DBCC CHECKIDENT ('dbo.Projects', RESEED, 1000);");
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
