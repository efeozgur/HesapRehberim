namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YaklasikMaliyet", "metin", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.YaklasikMaliyet", "metin");
        }
    }
}
