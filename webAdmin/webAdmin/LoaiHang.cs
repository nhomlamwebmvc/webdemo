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
    
    public partial class LoaiHang
    {
        public LoaiHang()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    
        public string MaLH { get; set; }
        public string TenLoaiHang { get; set; }
    
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}