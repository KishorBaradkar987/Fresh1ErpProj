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
    
    public partial class tblmodule_topic
    {
        public int module_topic_id { get; set; }
        public Nullable<int> module_id { get; set; }
        public Nullable<int> topic_id { get; set; }
        public Nullable<int> flag { get; set; }
    
        public virtual tbltraining_modules tbltraining_modules { get; set; }
        public virtual tbltraining_topics tbltraining_topics { get; set; }
    }
}
