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
    
    public partial class TBLKAMPANYABASLIK
    {
        public int IND { get; set; }
        public string CARIGRUBU { get; set; }
        public string ACIKLAMA { get; set; }
        public string ANLASMANO { get; set; }
        public Nullable<System.DateTime> BASTARIH { get; set; }
        public Nullable<System.DateTime> BITTARIH { get; set; }
        public string SUBEADI { get; set; }
        public Nullable<decimal> MAXALISVERISTUTARI { get; set; }
        public Nullable<decimal> ALISVERISINDIRIMTUTARI { get; set; }
        public Nullable<decimal> ALISVERISINDIRIMORANI { get; set; }
        public Nullable<int> KAMPANYATIPI { get; set; }
        public Nullable<int> ONCELIKSIRASI { get; set; }
        public Nullable<int> KAMPANYAEVRAKTIPI { get; set; }
    }
}
