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
    
    public partial class TBLBANKHAREKET
    {
        public int IND { get; set; }
        public Nullable<int> LINES_LINK { get; set; }
        public Nullable<int> CEKSENETLINK { get; set; }
        public Nullable<int> LN { get; set; }
        public string DURUM { get; set; }
        public Nullable<int> EVRAKNO { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> VADE { get; set; }
        public Nullable<decimal> BORC { get; set; }
        public Nullable<decimal> ALACAK { get; set; }
        public string SONDURUM { get; set; }
    }
}