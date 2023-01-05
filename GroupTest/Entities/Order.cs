using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Order
{
    public int Id { get; set; }
    public int Location { get; set; }
    public List<Item> Items { get; set; } = new List<Item>();

    public Decimal GrandTotal
    {
        get
        {
            var grandTotal= Items.Sum(i=>i.Cost);
            return grandTotal;
         }
    }
}
