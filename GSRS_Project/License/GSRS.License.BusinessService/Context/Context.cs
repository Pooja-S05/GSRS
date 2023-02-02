using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.License.BusinessService.Context.Dbsets;
using GSRS.Services.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace GSRS.License.BusinessService.Context
{
    public partial class Context:BaseContext,IContext
    {
        public Context(DbContextOptions<Context> options) : base(ContextHelper.ChangeOptionsType<BaseContext> (options))
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());
            }
            base.OnModelCreating(modelBuilder);
        }

    }
}