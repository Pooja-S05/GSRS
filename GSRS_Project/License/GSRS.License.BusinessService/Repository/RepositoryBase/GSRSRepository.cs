using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.License.BusinessService.Models;
using GSRS.Services.Models;
using GSRS.Services.Repository;

namespace GSRS.License.BusinessService.Repository.RepositoryBase
{
    public class GSRSRepository<TEntity>:BaseRepositoryAsync<TEntity> where TEntity:BaseModel
    {
        public GSRSRepository(ProjectgpContext _context) : base(_context)
        {
        }
    }
}