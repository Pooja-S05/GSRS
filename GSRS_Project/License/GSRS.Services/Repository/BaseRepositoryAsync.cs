using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.Services.ContextContracts;
using GSRS.Services.Models;
using GSRS.Services.RepositoryContracts;

namespace GSRS.Services.Repository
{
    public class BaseRepositoryAsync<TEntity>:IBaseRepositoryAsync<TEntity> where TEntity:BaseModel
    {

        private readonly IBaseContext Context;
        protected BaseRepositoryAsync(IBaseContext _context)
        {
            Context=_context;
        }


        public virtual async Task<int> CreateAsync(TEntity entity)
        {
            int add=1;
            return add;
        }
    }
}