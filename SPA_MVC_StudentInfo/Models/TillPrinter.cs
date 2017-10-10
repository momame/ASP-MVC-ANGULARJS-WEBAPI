//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_MVC_PCDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TillPrinter
    {
        public int TillPrinterID { get; set; }
        public string TillPrintingName { get; set; }
        public Nullable<bool> Line1DateEn { get; set; }
        public Nullable<bool> Line2DateEn { get; set; }
        public Nullable<bool> Line3DateEn { get; set; }
        public Nullable<bool> Line1DateIsJulian { get; set; }
        public Nullable<bool> Line2DateIsJulian { get; set; }
        public Nullable<bool> Line3DateIsJulian { get; set; }
        public string Line1DateFormat { get; set; }
        public string Line2DateFormat { get; set; }
        public string Line3DateFormat { get; set; }
        public Nullable<int> Line1DateOffset { get; set; }
        public Nullable<int> Line2DateOffset { get; set; }
        public Nullable<int> Line3DateOffset { get; set; }
        public string Line1TextPre { get; set; }
        public string Line2TextPre { get; set; }
        public string Line3TextPre { get; set; }
        public string Line1Text { get; set; }
        public string Line2Text { get; set; }
        public string Line3Text { get; set; }
        public Nullable<int> OperatorCodeLine { get; set; }
        public string CreatedSource { get; set; }
        public System.DateTimeOffset CreatedDTS { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateSource { get; set; }
        public System.DateTimeOffset UpdateDTS { get; set; }
        public string UpdateBy { get; set; }
    }
}
