using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.License.BusinessService.Models;
using GSRS.Services.RepositoryContracts;

namespace GSRS.License.BusinessService.RepositoryContracts
{
    public interface ILicenseRepository:IBaseRepositoryAsync<LicenseServerGroup>
    {
        
    }
}