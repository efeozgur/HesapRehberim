using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HesapRehberim.Models.Modeller;


namespace HesapRehberim.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Kisiler> Kisiler { get; set; }
        public DbSet<Malzeme> Malzemeler { get; set; }
        public DbSet<IsTanimi> IsTanimi { get; set; }
        public DbSet<KanitlayiciBelgeler> KanitlayiciBelgeler { get; set; }
        public DbSet<YaklasikMaliyet> YaklasikMaliyet { get; set; }
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Unvanlar> Unvanlar { get; set; }

    }
}