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
    
    public partial class vw_Invoices
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public System.TimeSpan InvoiceTime { get; set; }
        public Nullable<int> AppointmentId { get; set; }
        public int BranchId { get; set; }
        public int ProviderId { get; set; }
        public int PatientId { get; set; }
        public int ClinicId { get; set; }
        public Nullable<int> PracticeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<double> PatientDiscount { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }
        public double PaidTotal { get; set; }
        public double InvoiceTotal { get; set; }
        public double InvoiceDiscount { get; set; }
        public double PatientNewBalance { get; set; }
        public double PatientPreviousBalance { get; set; }
        public int InvoiceStatus { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string PatientName { get; set; }
        public string ProviderName { get; set; }
        public int LanguageId { get; set; }
    }
}
