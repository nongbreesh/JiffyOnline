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
    
    public partial class T_CUSTOMER
    {
        public int ID { get; set; }
        public Nullable<int> CUSTOMER_GROUP { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime DATE_OF_BIRTH { get; set; }
        public short SEND_NEWS { get; set; }
        public string AUTH_USER { get; set; }
        public string AUTH_PASS { get; set; }
        public string TYPE { get; set; }
        public string COMPANYNAME { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string ADDRESS3 { get; set; }
        public string ADDRESS4 { get; set; }
        public int PROVINCE_ID { get; set; }
        public int DISTRICT_ID { get; set; }
        public int AMPHUR_ID { get; set; }
        public string POSTCODE { get; set; }
        public string TEL { get; set; }
        public string MOBILE { get; set; }
        public string FAX { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string UPDATE_BY { get; set; }
        public Nullable<System.DateTime> DELETE_DATE { get; set; }
        public string DELETE_BY { get; set; }
        public string GENDER { get; set; }
        public Nullable<int> POINT { get; set; }
    
        public virtual T_CUSTOMER_GROUP T_CUSTOMER_GROUP { get; set; }
    }
}
