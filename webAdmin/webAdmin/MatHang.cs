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
    
    public partial class MatHang
    {
        public MatHang()
        {
            this.ChiTietDatHangs = new HashSet<ChiTietDatHang>();
        }
    
        public string MaHang { get; set; }
        public string MaCT { get; set; }
        public string MaLH { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<decimal> DonGiaNhap { get; set; }
        public Nullable<decimal> DonGiaBan { get; set; }
        public string TenHang { get; set; }
    
        public virtual ICollection<ChiTietDatHang> ChiTietDatHangs { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}