//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ck_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.leads = new HashSet<lead>();
        }
    
        public int customer_number { get; set; }
        public string customer_firstname { get; set; }
        public string customer_middlename { get; set; }
        public string customer_lastname { get; set; }
        public string phone_number { get; set; }
        public string second_phone_number { get; set; }
        public string email { get; set; }
        public Nullable<int> address_number { get; set; }
    
        public virtual address address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lead> leads { get; set; }
    }
}
