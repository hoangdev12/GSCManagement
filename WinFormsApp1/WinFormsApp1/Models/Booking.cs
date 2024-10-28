using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int CustomerId { get; set; }

    public int ComputerId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();

    public virtual ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();

    public virtual Computer Computer { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
