namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "Roles_ID", "dbo.Roles");
            DropIndex("dbo.UserRoles", new[] { "User_ID" });
            DropIndex("dbo.UserRoles", new[] { "Roles_ID" });
            AddColumn("dbo.Users", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "RoleId");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "ID", cascadeDelete: true);
            DropTable("dbo.UserRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Roles_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Roles_ID });
            
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropColumn("dbo.Users", "RoleId");
            CreateIndex("dbo.UserRoles", "Roles_ID");
            CreateIndex("dbo.UserRoles", "User_ID");
            AddForeignKey("dbo.UserRoles", "Roles_ID", "dbo.Roles", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserRoles", "User_ID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
