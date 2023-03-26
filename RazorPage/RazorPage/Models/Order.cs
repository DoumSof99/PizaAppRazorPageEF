using System;
using System.Collections.Generic;

namespace RazorPage.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
