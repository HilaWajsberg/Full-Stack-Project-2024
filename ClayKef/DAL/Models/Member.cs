using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Member
{
    public int Code { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string CellPhone { get; set; } = null!;

    public string? Email { get; set; }

    public int GroupCode { get; set; }

    public int TOrP { get; set; }
}
