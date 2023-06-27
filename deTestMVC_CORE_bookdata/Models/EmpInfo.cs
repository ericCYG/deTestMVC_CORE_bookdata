using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class EmpInfo
{
    public string EmpNo { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string BranchNo { get; set; } = null!;

    public string? BossEmpNo { get; set; }
}
