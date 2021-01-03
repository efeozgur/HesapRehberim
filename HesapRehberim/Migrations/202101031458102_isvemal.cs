namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isvemal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Malzeme", "IsTanimi_ID", c => c.Int());
            CreateIndex("dbo.Malzeme", "IsTanimi_ID");
            AddForeignKey("dbo.Malzeme", "IsTanimi_ID", "dbo.IsTanimi", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Malzeme", "IsTanimi_ID", "dbo.IsTanimi");
            DropIndex("dbo.Malzeme", new[] { "IsTanimi_ID" });
            DropColumn("dbo.Malzeme", "IsTanimi_ID");
        }
    }
}
