//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginsDB.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class login
    {
        public int login_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string website { get; set; }
        public string price_per_month { get; set; }
        public Nullable<System.DateTime> renewal_date { get; set; }
        public string account { get; set; }
    }
}
