namespace QLBVMB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("datvemaybay")]
    public partial class datvemaybay
    {
        [Key]
        [Column("Mã chuyến bay")]
        [StringLength(10)]
        public string Mã_chuyến_bay { get; set; }

        [Column("Nơi khởi hành")]
        [Required]
        [StringLength(10)]
        public string Nơi_khởi_hành { get; set; }

        [Column("Nơi đến")]
        [Required]
        [StringLength(10)]
        public string Nơi_đến { get; set; }

        [Column("Thời gian khởi hành")]
        public TimeSpan Thời_gian_khởi_hành { get; set; }

        [Column("Thời gian đến")]
        public TimeSpan Thời_gian_đến { get; set; }

        [Column("Ngày đi", TypeName = "date")]
        public DateTime Ngày_đi { get; set; }

        [Column("Ngày về", TypeName = "date")]
        public DateTime? Ngày_về { get; set; }

        [Column("Hạng vé")]
        [Required]
        public string Hạng_vé { get; set; }

        [Column("Kiểu vé")]
        [Required]
        [StringLength(50)]
        public string Kiểu_vé { get; set; }

        [Column("Máy bay")]
        [Required]
        [StringLength(150)]
        public string Máy_bay { get; set; }

        public decimal Giá { get; set; }
    }
}
