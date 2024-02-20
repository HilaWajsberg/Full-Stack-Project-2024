using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductType
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;

    public string Technique { get; set; } = null!;

    public int PricingCode { get; set; }
}
