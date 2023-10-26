namespace QLBVMB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(14)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(50)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(150)]
        public string TinhThanh { get; set; }
    }
}
