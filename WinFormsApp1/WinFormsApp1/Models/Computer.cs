using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Computer
{
    public int ComputerId { get; set; }

    public string ComputerName { get; set; } = null!;

    public string? Status { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
