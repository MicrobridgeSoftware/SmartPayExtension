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
    
    public partial class GuardType
    {
        public GuardType()
        {
            this.GuardStatusMappings = new HashSet<GuardStatusMapping>();
        }
    
        public int GuardTypeId { get; set; }
        public string GuardTypeDescription { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public bool Allowance { get; set; }
        public decimal Rate { get; set; }
        public string LastModifiedBy { get; set; }
    
        public virtual ICollection<GuardStatusMapping> GuardStatusMappings { get; set; }
    }
}