//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RasberryPiFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mostanadat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mostanadat()
        {
            this.Requests = new HashSet<Request>();
        }
    
        public int Mostanad_ID { get; set; }
        public string Mostanad_Name { get; set; }
        public int Msl7a_ID { get; set; }
    
        public virtual Msale7 Msale7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
