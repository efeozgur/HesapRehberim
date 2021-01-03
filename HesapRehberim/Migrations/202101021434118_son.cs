namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firma",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firmaAdi = c.String(nullable: false, maxLength: 100),
                        firmaTelefon = c.String(maxLength: 11),
                        firmaAdresi = c.String(nullable: false, maxLength: 200),
                        birimfiyat = c.Double(nullable: false),
                        YaklasikMaliyet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.YaklasikMaliyet", t => t.YaklasikMaliyet_ID)
                .Index(t => t.YaklasikMaliyet_ID);
            
            CreateTable(
                "dbo.IsTanimi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        dosyaNo = c.String(nullable: false, maxLength: 15),
                        isinAdi = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KanitlayiciBelgeler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        belgeAdi = c.String(nullable: false, maxLength: 100),
                        IsTanimi_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IsTanimi", t => t.IsTanimi_ID)
                .Index(t => t.IsTanimi_ID);
            
            CreateTable(
                "dbo.YaklasikMaliyet",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        birimFiyat = c.Double(nullable: false),
                        BirimOrtalama = c.Double(nullable: false),
                        ToplamOrtalama = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IsTanimi", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        adSoyad = c.String(nullable: false, maxLength: 50),
                        unvan = c.String(nullable: false, maxLength: 50),
                        FiyatIsteme_ID = c.Int(),
                        YaklasikMaliyet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FiyatIsteme", t => t.FiyatIsteme_ID)
                .ForeignKey("dbo.YaklasikMaliyet", t => t.YaklasikMaliyet_ID)
                .Index(t => t.FiyatIsteme_ID)
                .Index(t => t.YaklasikMaliyet_ID);
            
            CreateTable(
                "dbo.FiyatIsteme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        metin = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Malzeme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        malzemeAdi = c.String(nullable: false, maxLength: 100),
                        malzemeOzelligi = c.String(maxLength: 200),
                        miktari = c.Int(nullable: false),
                        olcuBirimi = c.String(nullable: false, maxLength: 15),
                        kdvOrani = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Unvanlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Unvan = c.String(nullable: false, maxLength: 50),
                        Kisiler_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kisiler", t => t.Kisiler_ID)
                .Index(t => t.Kisiler_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unvanlar", "Kisiler_ID", "dbo.Kisiler");
            DropForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.Kisiler", "FiyatIsteme_ID", "dbo.FiyatIsteme");
            DropForeignKey("dbo.YaklasikMaliyet", "ID", "dbo.IsTanimi");
            DropForeignKey("dbo.Firma", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.KanitlayiciBelgeler", "IsTanimi_ID", "dbo.IsTanimi");
            DropIndex("dbo.Unvanlar", new[] { "Kisiler_ID" });
            DropIndex("dbo.Kisiler", new[] { "YaklasikMaliyet_ID" });
            DropIndex("dbo.Kisiler", new[] { "FiyatIsteme_ID" });
            DropIndex("dbo.YaklasikMaliyet", new[] { "ID" });
            DropIndex("dbo.KanitlayiciBelgeler", new[] { "IsTanimi_ID" });
            DropIndex("dbo.Firma", new[] { "YaklasikMaliyet_ID" });
            DropTable("dbo.Unvanlar");
            DropTable("dbo.Malzeme");
            DropTable("dbo.FiyatIsteme");
            DropTable("dbo.Kisiler");
            DropTable("dbo.YaklasikMaliyet");
            DropTable("dbo.KanitlayiciBelgeler");
            DropTable("dbo.IsTanimi");
            DropTable("dbo.Firma");
        }
    }
}
