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
    
    public partial class TBLISSURECTALIMATBASLIK
    {
        public int IND { get; set; }
        public string BELGENO { get; set; }
        public Nullable<int> CARIIND { get; set; }
        public Nullable<int> STOKIND { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> MAKINAIND { get; set; }
        public Nullable<int> PERSONELIND { get; set; }
        public Nullable<int> MLZTESLIMIND { get; set; }
        public Nullable<int> SEVKIYATSORUMLUSU { get; set; }
        public Nullable<int> KESIMSORUMLUSU { get; set; }
        public Nullable<int> KKSORUMLUSU { get; set; }
        public string ONAYDURUMU { get; set; }
        public Nullable<System.DateTime> TALIMATSAATI { get; set; }
        public Nullable<System.DateTime> UREBASSAATI { get; set; }
        public Nullable<System.DateTime> UREBITSAATI { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<bool> IPTAL { get; set; }
    }
}
