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
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public int IDHD { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public Nullable<int> TONGTIEN { get; set; }
        public Nullable<bool> GIAOHANG { get; set; }
        public string TENKH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public string GHICHU { get; set; }
        public string TRANGTHAI { get; set; }
        public string THANHTOAN { get; set; }
        public Nullable<int> IDKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}