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
    
    public partial class TreatmentProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TreatmentProgram()
        {
            this.CompanyContractCoverages = new HashSet<CompanyContractCoverage>();
            this.CompanyContractPrices = new HashSet<CompanyContractPrice>();
            this.TreatmentProgramsServices = new HashSet<TreatmentProgramsService>();
        }
    
        public int TPID { get; set; }
        public string ProgramNo { get; set; }
        public string ProgramName_en { get; set; }
        public string ProgramName_ar { get; set; }
        public Nullable<int> PracticeId { get; set; }
        public bool IsEnable { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<double> TPPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContractCoverage> CompanyContractCoverages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContractPrice> CompanyContractPrices { get; set; }
        public virtual Practice Practice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentProgramsService> TreatmentProgramsServices { get; set; }
    }
}
