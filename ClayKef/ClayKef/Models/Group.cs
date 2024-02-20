using System;
using System.Collections.Generic;

namespace ClayKef.Models;

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

    public int MemberToGroupCode { get; set; }

    public virtual Age AgeCodeNavigation { get; set; } = null!;

    public virtual Duration DurationCodeNavigation { get; set; } = null!;

    public virtual GroupLevel GroupLevelCodeNavigation { get; set; } = null!;

    public virtual MemberToGroup MemberToGroupCodeNavigation { get; set; } = null!;

    public virtual Pricing PricingCodeNavigation { get; set; } = null!;

    public virtual ProductType? ProductTypeCodeNavigation { get; set; }

    public virtual Timing TimingCodeNavigation { get; set; } = null!;
}
