using System.Data.Entity.ModelConfiguration.Conventions;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;

namespace YuvamNerede.Model.Models.ORM.DBContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class YuvamNeredeDBContext : DbContext
    {
        
        public YuvamNeredeDBContext()
            : base("name=YuvamNeredeDBContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Category> Category{ get; set; }
        public virtual DbSet<Genus> Genus { get; set; }
        public virtual DbSet<SiteMenu> SiteMenu{ get; set; }

    }

}