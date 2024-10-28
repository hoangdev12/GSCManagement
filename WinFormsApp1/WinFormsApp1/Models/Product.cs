using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public int? StockQuantity { get; set; }

    public int? CategoryId { get; set; }

    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();

    public virtual Category? Category { get; set; }
}
