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
    
    public partial class TBLFASTERSATISHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> BASLIKIND { get; set; }
        public string BARCODE { get; set; }
        public Nullable<int> STOKIND { get; set; }
        public Nullable<int> BIRIMIND { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public Nullable<decimal> SATISFIYATI { get; set; }
        public Nullable<decimal> ISK1 { get; set; }
        public Nullable<decimal> ISK2 { get; set; }
        public Nullable<System.DateTime> ISLEMTARIHI { get; set; }
        public Nullable<int> PERNO { get; set; }
        public string PERKODU { get; set; }
        public string SERINO { get; set; }
        public Nullable<int> SERINO_IND { get; set; }
        public Nullable<int> SUBEIND { get; set; }
        public Nullable<int> KASAIND { get; set; }
        public Nullable<bool> AKTARILDI { get; set; }
        public Nullable<int> SUBESATISIND { get; set; }
        public Nullable<int> CARIIND { get; set; }
        public string DOSYAADI { get; set; }
        public Nullable<bool> ONLINE { get; set; }
        public Nullable<int> DEPOIND { get; set; }
        public string BASBARCODE { get; set; }
    }
}