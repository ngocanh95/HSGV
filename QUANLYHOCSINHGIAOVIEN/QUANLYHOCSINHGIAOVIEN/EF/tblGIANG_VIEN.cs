namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblGIANG_VIEN
    {
        [Key]
        [StringLength(10)]
        public string MaGV { get; set; }

        [StringLength(30)]
        public string TenGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySInh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhanLoaiGV { get; set; }

        [StringLength(10)]
        public string MaKhoa { get; set; }
    }
}
