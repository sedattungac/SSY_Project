//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSY_Project.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Data_Tahsilat
    {
        public string IND { get; set; }
        public string BELGEIND { get; set; }
        public string FIRMANO { get; set; }
        public string TARIH { get; set; }
        public string IZAHAT { get; set; }
        public string EVRAKNO { get; set; }
        public string IADE { get; set; }
        public string ODEMETARIHI { get; set; }
        public string FIRMAADI { get; set; }
        public string KREDILIMITI { get; set; }
        public string RISKLIMITI { get; set; }
        public string SONBAKIYE { get; set; }
        public string KOD5 { get; set; }
        public string STATUS { get; set; }
        public string GSMNO { get; set; }
        public string TLBORC { get; set; }
        public string TLALACAK { get; set; }
        public string TLBAKIYE { get; set; }
        public string PARABIRIMI { get; set; }
        public string UNVAN { get; set; }
        public string PERSONELNO { get; set; }
        public string GTARIH { get; set; }
    
        public virtual Data_CariList Data_CariList { get; set; }
        public virtual Data_TahsDet Data_TahsDet { get; set; }
    }
}
