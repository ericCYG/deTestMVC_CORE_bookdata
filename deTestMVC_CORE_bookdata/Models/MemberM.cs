using System;
using System.Collections.Generic;

namespace deTestMVC_CORE_bookdata.Models;

public partial class MemberM
{
    public string UserId { get; set; } = null!;

    public string? UserCname { get; set; }

    public string? UserEname { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyUser { get; set; }
}
