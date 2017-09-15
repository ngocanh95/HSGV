namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKHOA")]
    public partial class tblKHOA
    {
        [Key]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [StringLength(50)]
        public string TenKhoa { get; set; }
    }
}
