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
    
    public partial class TBLKIRAANLASMAHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> BASLIKIND { get; set; }
        public Nullable<int> STOKNO { get; set; }
        public string STOKKODU { get; set; }
        public string MALINCINSI { get; set; }
        public Nullable<int> HZSTOKNO { get; set; }
        public string HZSTOKKODU { get; set; }
        public string HZMALINCINSI { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<System.DateTime> BASTARIH { get; set; }
        public Nullable<System.DateTime> BITTARIH { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<bool> FATURALASTI { get; set; }
        public Nullable<int> FATURAIND { get; set; }
        public Nullable<bool> DEPOBELGESI { get; set; }
        public Nullable<int> DEPOBELGEIND { get; set; }
        public Nullable<bool> SEC { get; set; }
        public Nullable<int> BIRIMIND { get; set; }
        public Nullable<int> HZBIRIMIND { get; set; }
        public Nullable<decimal> GUN { get; set; }
        public Nullable<bool> IRSALIYE { get; set; }
        public Nullable<int> IRSALIYEIND { get; set; }
        public Nullable<bool> ZDUSURME { get; set; }
        public Nullable<int> ZDUSURMEIND { get; set; }
        public string ISLEM { get; set; }
    }
}
