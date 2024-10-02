using System;
using System.Collections.Generic;

namespace HomeWork6_1_3.DbModels;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public double Cost { get; set; }

    public string Description { get; set; } = null!;

    public int Quantity { get; set; }
}
