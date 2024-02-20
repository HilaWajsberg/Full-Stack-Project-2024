using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class ProductType
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;

    public string Technique { get; set; } = null!;

    public int PricingCode { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual Pricing PricingCodeNavigation { get; set; } = null!;
}
