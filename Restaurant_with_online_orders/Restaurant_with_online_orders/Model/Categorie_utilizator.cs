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
    
    public partial class Categorie_utilizator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categorie_utilizator()
        {
            this.Cont_utilizator = new HashSet<Cont_utilizator>();
        }
    
        public int id_catUser { get; set; }
        public string tip_User { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cont_utilizator> Cont_utilizator { get; set; }
    }
}
