//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonDatHang
    {
        public DonDatHang()
        {
            this.ChiTietDatHangs = new HashSet<ChiTietDatHang>();
        }
    
        public int SoHoaDon { get; set; }
        public Nullable<System.DateTime> NgayGiaoHang { get; set; }
        public string DiaChiNhan { get; set; }
        public string TenKhachHang { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
    
        public virtual ICollection<ChiTietDatHang> ChiTietDatHangs { get; set; }
    }
}
