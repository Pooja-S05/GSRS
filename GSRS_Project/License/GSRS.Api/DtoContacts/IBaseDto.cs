using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSRS.Api.DtoContacts
{
    public interface IBaseDto:IAuditDto
    {
        int id{get;set;}
    }
}