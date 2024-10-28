﻿using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();
}
