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
    
    public partial class T_BRAND
    {
        public T_BRAND()
        {
            this.T_PRODUCTS = new HashSet<T_PRODUCTS>();
        }
    
        public int ID { get; set; }
        public string NAME_TH { get; set; }
        public string NAME_EN { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
        public string DELETE_BY { get; set; }
        public short ACTIVE { get; set; }
    
        public virtual ICollection<T_PRODUCTS> T_PRODUCTS { get; set; }
    }
}