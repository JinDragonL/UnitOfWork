//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleMVC_UOW_Pattern.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Account
    {
        public int Account_ID { get; set; }
        public string Account_Email { get; set; }
        public string Account_Password { get; set; }
        public Nullable<bool> Account_Status { get; set; }
        public Nullable<int> AccType { get; set; }
    
        public virtual tbl_AccType tbl_AccType { get; set; }
    }
}