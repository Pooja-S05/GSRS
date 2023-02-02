using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.License.BusinessService.Models;
using GSRS.License.BusinessService.Repository.RepositoryBase;
using GSRS.License.BusinessService.RepositoryContracts;


namespace GSRS.License.BusinessService.Repository
{
    public class LicenseRepository:GSRSRepository<LicenseServerGroup>,ILicenseRepository
    {
        public readonly ProjectgpContext Context;
        public LicenseRepository(ProjectgpContext _context)
        {
            Context=_context;
        }
    }
}