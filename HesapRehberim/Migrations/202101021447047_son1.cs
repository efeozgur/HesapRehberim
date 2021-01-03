namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Firma", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropIndex("dbo.Firma", new[] { "YaklasikMaliyet_ID" });
            DropIndex("dbo.YaklasikMaliyet", new[] { "ID" });
            DropPrimaryKey("dbo.YaklasikMaliyet");
            AlterColumn("dbo.YaklasikMaliyet", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.YaklasikMaliyet", "ID");
            CreateIndex("dbo.YaklasikMaliyet", "ID");
            AddForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet", "ID");
            DropColumn("dbo.Firma", "YaklasikMaliyet_ID");
            DropColumn("dbo.YaklasikMaliyet", "birimFiyat");
            DropColumn("dbo.YaklasikMaliyet", "BirimOrtalama");
            DropColumn("dbo.YaklasikMaliyet", "ToplamOrtalama");
        }
        
        public override void Down()
        {
            AddColumn("dbo.YaklasikMaliyet", "ToplamOrtalama", c => c.Double(nullable: false));
            AddColumn("dbo.YaklasikMaliyet", "BirimOrtalama", c => c.Double(nullable: false));
            AddColumn("dbo.YaklasikMaliyet", "birimFiyat", c => c.Double(nullable: false));
            AddColumn("dbo.Firma", "YaklasikMaliyet_ID", c => c.Int());
            DropForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropIndex("dbo.YaklasikMaliyet", new[] { "ID" });
            DropPrimaryKey("dbo.YaklasikMaliyet");
            AlterColumn("dbo.YaklasikMaliyet", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.YaklasikMaliyet", "ID");
            CreateIndex("dbo.YaklasikMaliyet", "ID");
            CreateIndex("dbo.Firma", "YaklasikMaliyet_ID");
            AddForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet", "ID");
            AddForeignKey("dbo.Firma", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet", "ID");
        }
    }
}
