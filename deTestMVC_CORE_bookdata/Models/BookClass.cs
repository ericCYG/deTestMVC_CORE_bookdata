using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class BookClass
{
    public string BookClassId { get; set; } = null!;

    public string BookClassName { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyUser { get; set; }
}
