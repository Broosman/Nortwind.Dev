using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}


namespace Northwind.Api.Entities.Aggregations
{
    public class Shipper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shipper()
        {
            this.Orders = new HashSet<Order>();
        }
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}