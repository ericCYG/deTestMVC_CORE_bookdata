using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class UseRecord
{
    public string? UserId { get; set; }

    public string? UseDateStart { get; set; }

    public string? UseTimeStart { get; set; }

    public string? UseDateEnd { get; set; }

    public string? UseTimeEnd { get; set; }

    public string? UsePlace { get; set; }
}
