//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSY_Project.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCRMILISKILIBELGELER
    {
        public int IND { get; set; }
        public Nullable<int> BELGETIPI { get; set; }
        public Nullable<int> BELGEBASLIKREF { get; set; }
        public Nullable<int> CRMGORUSMEBASLIKREF { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.DateTime> ODEMETARIHI { get; set; }
        public string BELGENO { get; set; }
        public Nullable<short> DONEM { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
    }
}
