//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jiffyOnline.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_USERS
    {
        public int ID { get; set; }
        public string FNAME_TH { get; set; }
        public string FNAME_EN { get; set; }
        public string LNAME_TH { get; set; }
        public string LNAME_EN { get; set; }
        public string AUTH_USER { get; set; }
        public string AUTH_PASS { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
        public string DELETE_BY { get; set; }
        public int ROLE_ID { get; set; }
        public Nullable<short> ACTIVE { get; set; }
    
        public virtual T_ROLE T_ROLE { get; set; }
    }
}
