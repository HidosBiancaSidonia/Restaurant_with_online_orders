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
    
    public partial class Meniu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meniu()
        {
            this.Items = new HashSet<Item>();
            this.Meniu_Preparat = new HashSet<Meniu_Preparat>();
        }
    
        public int id_meniu { get; set; }
        public string denumire_meniu { get; set; }
        public string fotografie { get; set; }
        public Nullable<int> id_categorie { get; set; }
    
        public virtual Categorie_preparat Categorie_preparat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meniu_Preparat> Meniu_Preparat { get; set; }
    }
}
