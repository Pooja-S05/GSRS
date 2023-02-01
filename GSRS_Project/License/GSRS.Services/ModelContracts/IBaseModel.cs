using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSRS.Services.ModelContracts
{
    public interface IBaseModel:IAuditModel
    {
        int id {get;set;}
    }
}