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
    
    public partial class ImportCalcuationDetailsView
    {
        public int ImportedTransId { get; set; }
        public string TransactionDate { get; set; }
        public string ServiceCode { get; set; }
        public decimal ShiftTotal { get; set; }
        public int CustomerId { get; set; }
        public int ContractorId { get; set; }
        public string ContractorFirstName { get; set; }
        public string ContractorLastName { get; set; }
        public string ContractorDescription { get; set; }
        public string CustomerDescription { get; set; }
        public Nullable<decimal> DutyRate { get; set; }
        public string ContractorRef { get; set; }
        public string DutyDescription { get; set; }
        public string PayrollCode { get; set; }
        public int ReferenceId { get; set; }
        public Nullable<bool> IsAllowance { get; set; }
        public int DutyAllowanceId { get; set; }
        public int DutyId { get; set; }
        public Nullable<decimal> AllowanceHrs { get; set; }
        public string Branch { get; set; }
    }
}