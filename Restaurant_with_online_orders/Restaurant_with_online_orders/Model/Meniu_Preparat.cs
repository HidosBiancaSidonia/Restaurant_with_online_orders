//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_with_online_orders.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meniu_Preparat
    {
        public int id_meniu_preparat { get; set; }
        public int id_meinu { get; set; }
        public int id_preparat { get; set; }
    
        public virtual Meniu Meniu { get; set; }
        public virtual Preparat Preparat { get; set; }
    }
}
