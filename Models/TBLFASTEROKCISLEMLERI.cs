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
    
    public partial class TBLFASTEROKCISLEMLERI
    {
        public int IND { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.DateTime> VARDIYATARIHI { get; set; }
        public Nullable<int> VARDIYAIND { get; set; }
        public Nullable<int> SUBEIND { get; set; }
        public string SUBEADI { get; set; }
        public Nullable<int> KASAIND { get; set; }
        public string KASAADI { get; set; }
        public string VARDIYA { get; set; }
        public Nullable<decimal> OKCGIDEN { get; set; }
        public Nullable<decimal> OKCGELEN { get; set; }
        public Nullable<int> USERNO { get; set; }
        public Nullable<int> ODEMETURU { get; set; }
        public Nullable<int> OKCTURU { get; set; }
        public string BELGENO { get; set; }
        public Nullable<bool> FISIPTAL { get; set; }
        public Nullable<bool> FATURA { get; set; }
    }
}
