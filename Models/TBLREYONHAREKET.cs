//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSY_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLREYONHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> BASLIKIND { get; set; }
        public Nullable<int> STOKIND { get; set; }
        public string STOKKODU { get; set; }
        public string MALINCINSI { get; set; }
        public string BARKOD { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public string PARABIRIMI { get; set; }
        public Nullable<int> BELGEIND { get; set; }
        public Nullable<int> BELGEIZAHAT { get; set; }
        public Nullable<decimal> ISKORANI1 { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
    }
}
