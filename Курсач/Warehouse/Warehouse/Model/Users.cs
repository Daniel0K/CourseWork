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
    
    public partial class Users
    {
        public Users()
        {
            this.Order = new HashSet<Order>();
            this.Users_inv = new HashSet<Users_inv>();
        }
    
        public decimal id_user { get; set; }
        public string family { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public decimal id_role { get; set; }
    
        public virtual ICollection<Order> Order { get; set; }
        public virtual Role Role { get; set; }
        public virtual User_Inf User_Inf { get; set; }
        public virtual ICollection<Users_inv> Users_inv { get; set; }
    }
}
