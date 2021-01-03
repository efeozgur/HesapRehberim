namespace HesapRehberim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YaklasikMaliyet", "konu", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.YaklasikMaliyet", "konu");
        }
    }
}
