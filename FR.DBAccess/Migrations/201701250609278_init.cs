namespace FR.DBAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faces",
                c => new
                    {
                        FaceId = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                        Nic = c.String(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FaceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Faces");
        }
    }
}
