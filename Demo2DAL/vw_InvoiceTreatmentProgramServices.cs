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
    
    public partial class vw_InvoiceTreatmentProgramServices
    {
        public int IsService { get; set; }
        public int TPServiceID { get; set; }
        public int ServiceAndTPID { get; set; }
        public string ServiceAndTPCode { get; set; }
        public string ServiceAndTPDescription_en { get; set; }
        public string ServiceAndTPDescription_ar { get; set; }
        public Nullable<double> Price { get; set; }
        public int Qty { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> WithDiscountPrice { get; set; }
    }
}
