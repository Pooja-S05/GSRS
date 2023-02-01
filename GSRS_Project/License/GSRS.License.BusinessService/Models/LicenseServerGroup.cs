using System;
using System.Collections.Generic;
using GSRS.Services.Models;

namespace GSRS.License.BusinessService.Models;

public partial class LicenseServerGroup:BaseModel
{
    public int LicServerGroupId { get; set; }

    public string? ServerGroupName { get; set; }


    public string? CountryIso { get; set; }

    public virtual ICollection<LicenseServer> LicenseServers { get; } = new List<LicenseServer>();
}
