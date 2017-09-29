﻿using Northwind.Database.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Api.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public virtual Product Product { get; set; }

        public static OrderDetail Convert(NW_OrderDetail source)
        {
            var destination = new OrderDetail();
            destination.OrderID = source.OrderID;
            destination.ProductID = source.ProductID;
            destination.UnitPrice = source.UnitPrice;
            destination.Quantity = source.Quantity;
            destination.Discount = source.Discount;
            destination.Product = Product.Convert(source.Product);

            return destination;
        }

        public static NW_OrderDetail Convert(OrderDetail  source)
        {
            var destination = new NW_OrderDetail();
            destination.OrderID = source.OrderID;
            destination.ProductID = source.ProductID;
            destination.UnitPrice = source.UnitPrice;
            destination.Quantity = source.Quantity;
            destination.Discount = source.Discount;
            destination.Product = Product.Convert(source.Product);
            return destination;
        }
    }
}

