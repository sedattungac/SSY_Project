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
    
    public partial class TBLIMFSAYIMHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> STOKIND { get; set; }
        public Nullable<int> BIRIMIND { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<decimal> SAYILAN { get; set; }
        public Nullable<bool> AKTARILDI { get; set; }
        public Nullable<System.DateTime> ISLEMTARIHI { get; set; }
        public Nullable<int> USERIND { get; set; }
        public Nullable<int> BELGEIND { get; set; }
        public Nullable<int> BELGETIPI { get; set; }
        public Nullable<System.DateTime> MIADTARIHI { get; set; }
        public string STOKKODU { get; set; }
        public string MALINCINSI { get; set; }
        public Nullable<bool> MIADAKTARILDI { get; set; }
    }
}
