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
    
    public partial class TBLTEMLIKANLASMABASLIK
    {
        public int IND { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> FIRMANO { get; set; }
        public string FIRMAKODU { get; set; }
        public string FIRMAADI { get; set; }
        public string ANLASMANO { get; set; }
        public Nullable<System.DateTime> BASTARIH { get; set; }
        public Nullable<System.DateTime> BITTARIH { get; set; }
        public string PARABIRIMI { get; set; }
        public Nullable<int> KATILIMFIYATISTOKNO { get; set; }
        public string KATILIMFIYATISTOKKODU { get; set; }
        public string KATILIMFIYATISTOKADI { get; set; }
        public Nullable<int> KATILIMPRIMSTOKNO { get; set; }
        public string KATILIMPRIMSTOKKODU { get; set; }
        public string KATILIMPRIMSTOKADI { get; set; }
    }
}