//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.Database.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class NW_Territorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NW_Territorie()
        {
            this.NW_EmployeeTerritorie = new HashSet<NW_EmployeeTerritorie>();
        }
    
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NW_EmployeeTerritorie> NW_EmployeeTerritorie { get; set; }
        public virtual NW_Region NW_Region { get; set; }
    }
}
