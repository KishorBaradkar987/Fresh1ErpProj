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
    
    public partial class tblstudent_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblstudent_details()
        {
            this.tblstudent_qualifications = new HashSet<tblstudent_qualifications>();
            this.tblstudent_registration_details = new HashSet<tblstudent_registration_details>();
        }
    
        public int student_id { get; set; }
        public string student_code { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public string mobile_number { get; set; }
        public string alternative_number { get; set; }
        public string photo { get; set; }
        public Nullable<System.DateTime> birth_date { get; set; }
        public string password { get; set; }
        public Nullable<int> Location_id { get; set; }
        public string Local_Address { get; set; }
        public string Permenant_Address { get; set; }
        public Nullable<int> center_id { get; set; }
        public Nullable<int> flag { get; set; }
    
        public virtual tblcenter_details tblcenter_details { get; set; }
        public virtual tbllocation tbllocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblstudent_qualifications> tblstudent_qualifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblstudent_registration_details> tblstudent_registration_details { get; set; }
    }
}
