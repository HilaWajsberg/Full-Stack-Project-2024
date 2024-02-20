using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Group
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public DateTime OpeningDate { get; set; }

    public int NumOfMembers { get; set; }

    public int DurationCode { get; set; }

    public int TimingCode { get; set; }

    public int AgeCode { get; set; }

    public int PricingCode { get; set; }

    public int? ProductTypeCode { get; set; }

    public int GroupLevelCode { get; set; }
}
