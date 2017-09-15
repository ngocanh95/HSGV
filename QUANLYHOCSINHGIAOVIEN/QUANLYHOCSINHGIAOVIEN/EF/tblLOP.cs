namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLOP")]
    public partial class tblLOP
    {
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Key]
        [StringLength(10)]
        public string MaLop { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }
    }
}
