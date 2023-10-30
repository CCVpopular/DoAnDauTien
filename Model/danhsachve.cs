namespace QLBVMB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("danhsachve")]
    public partial class danhsachve
    {
        [Key]
        [Column("Mã vé chuyến bay")]
        [StringLength(10)]
        public string Mã_vé_chuyến_bay { get; set; }

        [Column("Mã chuyến bay")]
        [Required]
        [StringLength(10)]
        public string Mã_chuyến_bay { get; set; }

        [Column("Mã khách hàng")]
        [Required]
        [StringLength(10)]
        public string Mã_khách_hàng { get; set; }

        [StringLength(6)]
        public string MaHoaDon { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }
    }
}
