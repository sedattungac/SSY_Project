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
    
    public partial class TBLEFTBASLIK
    {
        public int IND { get; set; }
        public Nullable<int> BANKANO { get; set; }
        public string BELGENO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<bool> IPTAL { get; set; }
        public Nullable<int> USERNO { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> ODEMETARIHI { get; set; }
        public Nullable<int> DURUMU { get; set; }
        public string PARABIRIMI { get; set; }
        public Nullable<decimal> KUR { get; set; }
    }
}
