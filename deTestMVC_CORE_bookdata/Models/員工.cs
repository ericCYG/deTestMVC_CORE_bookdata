using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class 員工
{
    public string? 員工編號 { get; set; }

    public string? 員工姓名 { get; set; }

    public string? 部門編號 { get; set; }

    public DateTime? 上班開始日 { get; set; }

    public string? 職稱編號 { get; set; }

    public decimal? 薪水 { get; set; }
}
