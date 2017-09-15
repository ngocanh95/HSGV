namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HSGVDbContext : DbContext
    {
        public HSGVDbContext()
            : base("name=HSGVDbContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblGIANG_VIEN> tblGIANG_VIEN { get; set; }
        public virtual DbSet<tblKET_QUA> tblKET_QUA { get; set; }
        public virtual DbSet<tblKHOA> tblKHOAs { get; set; }
        public virtual DbSet<tblLOGIN> tblLOGINs { get; set; }
        public virtual DbSet<tblLOP> tblLOPs { get; set; }
        public virtual DbSet<tblMON> tblMONs { get; set; }
        public virtual DbSet<tblSINH_VIEN> tblSINH_VIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblGIANG_VIEN>()
                .Property(e => e.MaKhoa)
                .IsFixedLength();

            modelBuilder.Entity<tblMON>()
                .Property(e => e.MaKhoa)
                .IsFixedLength();
        }
    }
}
