//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCafe.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class lich_su_giao_dich
    {
        public int id { get; set; }
        public System.DateTime ngay_giao_dich { get; set; }
        public string loai_giao_dich { get; set; }
        public float tong_tien { get; set; }
        public int order_id { get; set; }
    
        public virtual order order { get; set; }
    }
}
