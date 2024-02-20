using System;
using System.Collections.Generic;

namespace ClayKef.Models;

public partial class MemberToGroup
{
    public int Code { get; set; }

    public int GroupCode { get; set; }

    public int MemberCode { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
