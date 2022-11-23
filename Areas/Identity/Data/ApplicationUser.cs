using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCoreIdentityCustom.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.NETCoreIdentityCustom.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public string Phone { get; set; }
    public string? Description { get; set; }
    public ReportCard ReportCard { get; set; }

}

public class ApplicationRole : IdentityRole
{

}
