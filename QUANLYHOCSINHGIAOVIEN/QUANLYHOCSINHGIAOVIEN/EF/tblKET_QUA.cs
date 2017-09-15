namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblKET_QUA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMon { get; set; }

        public double? DiemTB { get; set; }

        public double? DiemThiLan1 { get; set; }

        public double? DiemThiLan2 { get; set; }

        public double? DiemTongKet { get; set; }

        [StringLength(20)]
        public string HanhKiem { get; set; }

        public int? HocKi { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
