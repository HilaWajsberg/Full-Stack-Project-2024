using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class Pricing
{
    public int Code { get; set; }

    public int Price { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<ProductType> ProductTypes { get; set; } = new List<ProductType>();
}
