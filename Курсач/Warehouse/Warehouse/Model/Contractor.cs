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
    
    public partial class Contractor
    {
        public Contractor()
        {
            this.Invoice = new HashSet<Invoice>();
            this.Order = new HashSet<Order>();
        }
    
        public decimal id_contractor { get; set; }
        public string leg_adress { get; set; }
        public string actual_adress { get; set; }
        public string phones { get; set; }
        public decimal inn { get; set; }
        public string family { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public Nullable<decimal> bank_ac { get; set; }
        public Nullable<decimal> id_firm { get; set; }
    
        public virtual Firm Firm { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
