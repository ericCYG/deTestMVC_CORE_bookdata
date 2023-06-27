using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class Member
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Tel { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime Birthday { get; set; }
}
