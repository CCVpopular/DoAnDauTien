using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBVMB.Model
{
    public partial class ModelQLBVMB : DbContext
    {
        public ModelQLBVMB()
            : base("name=ModelQLBVMB5")
        {
        }

        public virtual DbSet<danhsachve> danhsachves { get; set; }
        public virtual DbSet<datvemaybay> datvemaybays { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<ThongTinThe> ThongTinThes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<danhsachve>()
                .Property(e => e.Mã_vé_chuyến_bay)
                .IsFixedLength();

            modelBuilder.Entity<danhsachve>()
                .Property(e => e.Mã_khách_hàng)
                .IsFixedLength();

            modelBuilder.Entity<danhsachve>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<datvemaybay>()
                .Property(e => e.Giá)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinThe>()
                .Property(e => e.sothe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThongTinThe>()
                .Property(e => e.pin)
                .HasPrecision(6, 0);
        }
    }
}
