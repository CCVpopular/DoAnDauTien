namespace QLBVMB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(6)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Column("Mã vé chuyến bay")]
        [Required]
        [StringLength(10)]
        public string Mã_vé_chuyến_bay { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLapHoaDon { get; set; }

        public double? Thue { get; set; }

        public double? TongTien { get; set; }
    }
}
