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
    
    public partial class SystemUser
    {
        public int SystemUserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[] UserImage { get; set; }
        public bool AccountExpirable { get; set; }
        public Nullable<int> ActivePeriod { get; set; }
        public bool RequireUserChange { get; set; }
        public Nullable<bool> CurrentlyLoggedIn { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
    }
}
