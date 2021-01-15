namespace QUANLYKHACHSAN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            CHI_TIET_HOA_DON = new HashSet<CHI_TIET_HOA_DON>();
        }

        [Key]
        [StringLength(5)]
        public string MaHoaDon { get; set; }

        [StringLength(5)]
        public string MaNhanVien { get; set; }

        public long? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON> CHI_TIET_HOA_DON { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
