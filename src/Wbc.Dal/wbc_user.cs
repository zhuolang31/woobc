//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wbc.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class wbc_user
    {
        public long ID { get; set; }
        public long CompanyID { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public string Mobile { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DataChange_LastTime { get; set; }
    }
}