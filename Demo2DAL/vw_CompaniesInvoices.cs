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
    
    public partial class vw_CompaniesInvoices
    {
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public int LanguageId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string CompanyNameEn { get; set; }
        public string CompanyNameAr { get; set; }
        public Nullable<int> InsurranceCompanyId { get; set; }
        public string InsurranceCompanyNameEn { get; set; }
        public string InsurranceCompanyNameAr { get; set; }
        public string MembershipId { get; set; }
        public Nullable<double> CompanyShared { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public int InvoiceStatus { get; set; }
    }
}
