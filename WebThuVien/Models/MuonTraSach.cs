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
    
    public partial class MuonTraSach
    {
        public int MaMuonTra { get; set; }
        public Nullable<int> SoThe { get; set; }
        public Nullable<int> MaDauSach { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayTraDuKien { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual DauSach DauSach { get; set; }
        public virtual TheThuVien TheThuVien { get; set; }
    }
}
