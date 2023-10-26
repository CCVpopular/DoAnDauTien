using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBVMB.Model
{
    public partial class ModelQLBVMB : DbContext
    {
        public ModelQLBVMB()
            : base("name=ModelQLBVMB")
        {
        }

        public virtual DbSet<danhsachve> danhsachves { get; set; }
        public virtual DbSet<datvemaybay> datvemaybays { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<danhsachve>()
                .Property(e => e.Mã_vé_chuyến_bay)
                .IsFixedLength();

            modelBuilder.Entity<danhsachve>()
                .Property(e => e.Mã_chuyến_bay)
                .IsFixedLength();

            modelBuilder.Entity<danhsachve>()
                .Property(e => e.Mã_khách_hàng)
                .IsFixedLength();

            modelBuilder.Entity<datvemaybay>()
                .Property(e => e.Giá)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MatKhau)
                .IsFixedLength();
        }
    }
}
