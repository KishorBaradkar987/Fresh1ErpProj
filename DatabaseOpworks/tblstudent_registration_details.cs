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
    
    public partial class tblstudent_registration_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblstudent_registration_details()
        {
            this.tblstudent_payment_details = new HashSet<tblstudent_payment_details>();
        }
    
        public int registration_id { get; set; }
        public string registration_code { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<System.DateTime> joining_date { get; set; }
        public Nullable<int> course_fee_id { get; set; }
        public Nullable<double> discount { get; set; }
        public string discount_reason { get; set; }
        public string current_status { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> flag { get; set; }
    
        public virtual tblcourse_fees tblcourse_fees { get; set; }
        public virtual tblemployee_details tblemployee_details { get; set; }
        public virtual tblstudent_details tblstudent_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblstudent_payment_details> tblstudent_payment_details { get; set; }
        public virtual tbltrainingcours tbltrainingcours { get; set; }
    }
}
