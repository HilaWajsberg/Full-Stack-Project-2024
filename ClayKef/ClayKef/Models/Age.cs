using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class Age
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
