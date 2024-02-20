using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Duration
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;
}
