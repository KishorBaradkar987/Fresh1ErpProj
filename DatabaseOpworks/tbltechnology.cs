//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseOpworks
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbltechnology
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbltechnology()
        {
            this.tbltrainingcourses = new HashSet<tbltrainingcours>();
        }
    
        public int technology_id { get; set; }
        public string technology_name { get; set; }
        public Nullable<int> flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbltrainingcours> tbltrainingcourses { get; set; }
    }
}