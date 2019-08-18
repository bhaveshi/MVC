namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Roles_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Roles_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Roles_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Roles_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Roles_ID", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "User_ID", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "Roles_ID" });
            DropIndex("dbo.UserRoles", new[] { "User_ID" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
