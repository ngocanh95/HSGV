namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSINH_VIEN
    {
        [Key]
        [StringLength(10)]
        public string MaSv { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string NgaySinh { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string MaLop { get; set; }
    }
}
