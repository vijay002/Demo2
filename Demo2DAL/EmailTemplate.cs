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
    
    public partial class EmailTemplate
    {
        public int EmailTemplateId { get; set; }
        public string EmailType { get; set; }
        public string Key { get; set; }
        public int LanguageId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public bool IsEnable { get; set; }
        public string PredefinedTags { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string MailTo { get; set; }
        public string MailCC { get; set; }
    }
}
