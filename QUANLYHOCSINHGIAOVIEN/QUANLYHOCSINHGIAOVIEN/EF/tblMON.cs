namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMON")]
    public partial class tblMON
    {
        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        public int? SoDVHT { get; set; }

        [StringLength(10)]
        public string HocKi { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }
    }
}
