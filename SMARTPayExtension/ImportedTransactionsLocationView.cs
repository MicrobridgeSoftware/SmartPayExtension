//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMARTPayExtension
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImportedTransactionsLocationView
    {
        public string CustomerRef { get; set; }
        public string CustomerDescription { get; set; }
        public string ZoneDescription { get; set; }
        public Nullable<int> TimesWorked { get; set; }
        public Nullable<decimal> HoursWorked { get; set; }
        public int ContractorId { get; set; }
        public string ContractorRef { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContractorDescription { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public System.DateTime DateImported { get; set; }
        public string FileSaveName { get; set; }
        public string ImportedBy { get; set; }
    }
}