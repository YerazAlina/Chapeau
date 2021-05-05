using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        //Class Order can contain a list of OrderItem-objects(and a Table instead of TableId, and a Employee instead of EmployeeId)
        public List<OrderItem> orderedItems = new List<OrderItem>();

        public int OrderNr { get; set; }
        public int TableID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Bill { get; set; }
    }
}
