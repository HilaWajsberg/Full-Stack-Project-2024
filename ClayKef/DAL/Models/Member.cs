using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Member
{
    public int Code { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string CellPhone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int MemberToCourseCode { get; set; }

    public int TOrF { get; set; }

    public string Password { get; set; } = null!;

    public virtual MemberToCourse MemberToCourseCodeNavigation { get; set; } = null!;
}
