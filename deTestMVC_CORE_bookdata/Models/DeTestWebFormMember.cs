using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class DeTestWebFormMember
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Sex { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }
}
