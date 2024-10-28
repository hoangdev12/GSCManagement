using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class BookingProduct
{
    public int BookingId { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalPrice { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
