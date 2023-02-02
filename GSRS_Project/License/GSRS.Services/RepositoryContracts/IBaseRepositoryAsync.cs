using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.Services.Models;

namespace GSRS.Services.RepositoryContracts
{
    public interface IBaseRepositoryAsync<TEntity> where TEntity:BaseModel
    {
        Task<int> CreateAsync(TEntity entity);
    }
}