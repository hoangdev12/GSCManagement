﻿using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Position { get; set; }

    public DateTime? HireDate { get; set; }

    public decimal? Salary { get; set; }
}