using Northwind.Database.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual Supplier Supplier { get; set; }

        public static Product Convert(NW_Product source)
        {
            var destination = new Product();
            destination.ProductID = source.ProductID;
            destination.ProductName = source.ProductName;
            destination.SupplierID = source.SupplierID;
            destination.CategoryID = source.CategoryID;
            destination.QuantityPerUnit = source.QuantityPerUnit;
            destination.UnitPrice = source.UnitPrice;
            destination.UnitsInStock = source.UnitsInStock;
            destination.UnitsOnOrder = source.UnitsOnOrder;
            destination.ReorderLevel = source.ReorderLevel;
            destination.Discontinued = source.Discontinued;

            return destination;
        }

        public static NW_Product Convert(Product  source)
        {
            var destination = new NW_Product();
            destination.ProductID = source.ProductID;
            destination.ProductName = source.ProductName;
            destination.SupplierID = source.SupplierID;
            destination.CategoryID = source.CategoryID;
            destination.QuantityPerUnit = source.QuantityPerUnit;
            destination.UnitPrice = source.UnitPrice;
            destination.UnitsInStock = source.UnitsInStock;
            destination.UnitsOnOrder = source.UnitsOnOrder;
            destination.ReorderLevel = source.ReorderLevel;
            destination.Discontinued = source.Discontinued;

            return destination;
        }

    }
}

