using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GSRS.License.BusinessService.Context.Dbsets
{
    public class LicenseServerGroup
    {
        public virtual DbSet<LicenseServerGroup> LicenseServerGroups { get; set; }
    }
}