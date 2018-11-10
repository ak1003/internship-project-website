//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Envision.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Internship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Internship()
        {
            this.Applieds = new HashSet<Applied>();
            this.InternshipLocations = new HashSet<InternshipLocation>();
            this.InternshipPerks = new HashSet<InternshipPerk>();
            this.InternshipSkills = new HashSet<InternshipSkill>();
        }
    
        public string Id { get; set; }
        public string C_Id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public System.DateTime ApplyBefore { get; set; }
        public Nullable<int> Stipend { get; set; }
        public string InternshipType { get; set; }
        public int InternshipIn { get; set; }
        public decimal AvailableSeats { get; set; }
        public decimal MinDuration { get; set; }
        public decimal MaxDuration { get; set; }
        public string ContactEmail { get; set; }
        public string ContactMobile { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string About { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applied> Applieds { get; set; }
        public virtual CategoriesList CategoriesList { get; set; }
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternshipLocation> InternshipLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternshipPerk> InternshipPerks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternshipSkill> InternshipSkills { get; set; }
    }
}