//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo2Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventLog
    {
        public long EventLogId { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModuleName { get; set; }
        public string Action { get; set; }
        public Nullable<int> ModuleId { get; set; }
    }
}
