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
    
    public partial class tbllocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbllocation()
        {
            this.tblemployee_details = new HashSet<tblemployee_details>();
            this.tblstudent_details = new HashSet<tblstudent_details>();
        }
    
        public int location_id { get; set; }
        public string location_name { get; set; }
        public Nullable<int> city_id { get; set; }
        public Nullable<int> flag { get; set; }
    
        public virtual tblcity tblcity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblemployee_details> tblemployee_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblstudent_details> tblstudent_details { get; set; }
    }
}
