//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Not_issued_goods
    {
        public decimal id_invoice { get; set; }
        public decimal id_merch { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public decimal count { get; set; }
        public System.DateTime data_get { get; set; }
        public bool paid { get; set; }
        public bool good_issue { get; set; }
    }
}
