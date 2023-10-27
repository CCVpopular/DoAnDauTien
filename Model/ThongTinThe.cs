namespace QLBVMB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinThe")]
    public partial class ThongTinThe
    {
        [Key]
        public decimal sothe { get; set; }

        public decimal pin { get; set; }
    }
}
