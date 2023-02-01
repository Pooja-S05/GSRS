using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSRS.Services.ModelContracts
{
    public interface IAuditModel
    {
        DateTime DateCreated {get; set;}
        DateTime DateChanged {get; set;}
        string ChangedBy {get; set;}
    }
}