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
    
    public partial class vw_Location
    {
        public int LocationId { get; set; }
        public string LocationName_en { get; set; }
        public string LocationName_ar { get; set; }
        public string LocationCode { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int LookupTypeId { get; set; }
        public string ParentLocationName_en { get; set; }
        public string ParentLocationName_ar { get; set; }
    }
}
