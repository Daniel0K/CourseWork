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
    
    public partial class Worktype
    {
        public Worktype()
        {
            this.Users_inv = new HashSet<Users_inv>();
        }
    
        public decimal id_worktype { get; set; }
        public string name_work { get; set; }
    
        public virtual ICollection<Users_inv> Users_inv { get; set; }
    }
}
