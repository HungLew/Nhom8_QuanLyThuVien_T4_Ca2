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
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.DauSaches = new HashSet<DauSach>();
        }
    
        public int ID_Sach { get; set; }
        public string TenSach { get; set; }
        public string ImageSach { get; set; }
        public Nullable<int> ID_TheLoai { get; set; }
        public Nullable<int> ID_TacGia { get; set; }
        public Nullable<int> ID_NXB { get; set; }
        public Nullable<int> NamXuatBan { get; set; }
        public string GioiThieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DauSach> DauSaches { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual TacGia TacGia { get; set; }
        public virtual TheLoai TheLoai { get; set; }
    }
}
