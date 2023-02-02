using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace GSRS.Services.ContextContracts
{
    public interface IBaseContext
    {
        DbSet<TEntity> SetEntity<TEntity>() where TEntity : BaseModel;

        IQueryable<TEntity> SetQuery<TEntity>() where TEntity : BaseModel;

        void SetAdded<TEntity>(TEntity entity) where TEntity:BaseModel;

        void SetModified<TEntity>(TEntity entity) where TEntity:BaseModel;

        void SetDeleted<TEntity>(TEntity entity) where TEntity:BaseModel;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        
        DbContext DbContext { get; }
    }
}