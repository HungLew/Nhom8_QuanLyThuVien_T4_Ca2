//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TheThuVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheThuVien()
        {
            this.MuonTraSaches = new HashSet<MuonTraSach>();
        }
    
        public int SoThe { get; set; }
        public string HoTenSinhVien { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string TinhTrangSuDung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonTraSach> MuonTraSaches { get; set; }
    }
}
