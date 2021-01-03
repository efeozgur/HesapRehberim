namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Malzeme", "YaklasikMaliyet_ID", c => c.Int());
            CreateIndex("dbo.Malzeme", "YaklasikMaliyet_ID");
            AddForeignKey("dbo.Malzeme", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Malzeme", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropIndex("dbo.Malzeme", new[] { "YaklasikMaliyet_ID" });
            DropColumn("dbo.Malzeme", "YaklasikMaliyet_ID");
        }
    }
}
