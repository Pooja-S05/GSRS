using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSRS.Api.DtoContacts
{
    public interface IAuditDto
    {
        DateTime DateCreated {get;set;}
        DateTime DateChanged {get;set;}
        string ChangedBy {get;set;}

    }
}