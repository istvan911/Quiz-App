namespace Lista_Kviz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Class4Valasz", "TemakorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Class4Valasz", "TemakorID", c => c.Int(nullable: false));
        }
    }
}
