using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class Lon
{
    public string LonNo { get; set; } = null!;

    public string CustId { get; set; } = null!;

    public decimal Amt { get; set; }

    public string Status { get; set; } = null!;

    public DateTime OpenDt { get; set; }

    public DateTime? CloseDt { get; set; }
}
