//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gym_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gym_Branch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gym_Branch()
        {
            this.physcial_details = new HashSet<physcial_details>();
        }
    
        public int GB_id { get; set; }
        public Nullable<int> trainee_id { get; set; }
        public Nullable<int> B_id { get; set; }
    
        public virtual trainee trainee { get; set; }
        public virtual Gym_Branch_1 Gym_Branch_1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<physcial_details> physcial_details { get; set; }
    }
}
