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
    
    public partial class F0111D0008TBLBANKAGENELHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> BANKANO { get; set; }
        public Nullable<int> BELGEIND { get; set; }
        public Nullable<int> ISLEMIND { get; set; }
        public Nullable<int> BELGEIZAHAT { get; set; }
        public Nullable<int> ISLEMIZAHAT { get; set; }
        public Nullable<int> BELGELINK { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.DateTime> VADE { get; set; }
        public Nullable<decimal> BORC { get; set; }
        public Nullable<decimal> ALACAK { get; set; }
        public Nullable<decimal> KOMISYON { get; set; }
        public Nullable<decimal> KUR { get; set; }
        public string PARABIRIMI { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
