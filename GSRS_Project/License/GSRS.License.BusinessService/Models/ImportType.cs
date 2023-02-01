using System;
using System.Collections.Generic;
using GSRS.Services.Models;

namespace GSRS.License.BusinessService.Models;

public partial class ImportType:BaseModel
{
    public int ImportTypeId { get; set; }

    public string? ImportTypeName { get; set; }

    public string? Descriptions { get; set; }

    

    public virtual ICollection<LicenseServer> LicenseServers { get; } = new List<LicenseServer>();

    public virtual ICollection<LicenseType> LicenseTypes { get; } = new List<LicenseType>();
}
