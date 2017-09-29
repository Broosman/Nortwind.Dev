using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public partial class Categorie
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}

namespace Northwind.Api.Entities.Aggregations
{
    public partial class Categorie
    {

        public Categorie()
        {
            this.Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}