namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PHIEU_SUA_CHUA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaPhieuSua { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaPhong { get; set; }

        public double? PhiSuaChua { get; set; }

        public virtual PHIEU_SUA_CHUA PHIEU_SUA_CHUA { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
