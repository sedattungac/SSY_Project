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
    
    public partial class TBLEFTHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> EVRAKNO { get; set; }
        public Nullable<int> FIRMANO { get; set; }
        public Nullable<int> BANKANO { get; set; }
        public Nullable<int> SUBENO { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public Nullable<bool> GERCEKLESTI { get; set; }
        public Nullable<bool> ONLINEISLEMEMRIVERILDI { get; set; }
        public Nullable<int> HAVALEIND { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<decimal> KUR { get; set; }
        public string PARABIRIMI { get; set; }
        public Nullable<bool> IPTAL { get; set; }
        public string DURUMU { get; set; }
        public string ISLEMREFERANSI { get; set; }
        public Nullable<int> EFTSORGUNUMARASI { get; set; }
    }
}
