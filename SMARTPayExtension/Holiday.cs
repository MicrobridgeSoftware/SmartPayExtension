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
    
    public partial class Holiday
    {
        public int HolidayId { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public int HolidayRateId { get; set; }
        public System.DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public string PayrollCode { get; set; }
    
        public virtual HolidayRate HolidayRate { get; set; }
    }
}
