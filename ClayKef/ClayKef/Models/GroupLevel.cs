using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class GroupLevel
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
