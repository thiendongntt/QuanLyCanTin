//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQuanLyCanTin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRALUONG
    {
        public int IDNV { get; set; }
        public System.DateTime NGAYBATDAU { get; set; }
        public System.DateTime NGAYKETTHUC { get; set; }
        public Nullable<int> SOCALAM { get; set; }
        public Nullable<int> LUONGTHUONG { get; set; }
        public Nullable<int> LUONGTONG { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
