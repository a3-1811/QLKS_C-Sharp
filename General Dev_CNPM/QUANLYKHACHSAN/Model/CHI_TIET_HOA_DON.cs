namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_HOA_DON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaThuePhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string MaThanhToan { get; set; }

        public double? TienPhong { get; set; }

        public double? TienDichVu { get; set; }

        public int? SoNgay { get; set; }

        public double? ThanhTien { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        public virtual LOAI_THANH_TOAN LOAI_THANH_TOAN { get; set; }

        public virtual PHIEU_THUE_PHONG PHIEU_THUE_PHONG { get; set; }
    }
}
