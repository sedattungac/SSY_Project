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
    
    public partial class TBLSNAPSHOTS
    {
        public int IND { get; set; }
        public string UID { get; set; }
        public Nullable<System.DateTime> SNAPSHOTDATE { get; set; }
        public string ACTION { get; set; }
        public string DATASETS { get; set; }
        public Nullable<int> USERNO { get; set; }
        public string USERNAME { get; set; }
        public string OWNERFORM { get; set; }
        public string CRC32 { get; set; }
    }
}
