using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class Timing
{
    public int Code { get; set; }

    public int Day { get; set; }

    public double Hour { get; set; }

    public DateTime? Date { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
