using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int CustomerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
