using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.Api.DtoContacts;

namespace GSRS.Api.Dtos
{
    public class BaseDto:IBaseDto
    {
        public int id {get;set;}

        public DateTime DateCreated {get;set;}
        
        public DateTime DateChanged {get;set;}

        public string? ChangedBy {get;set;}
    }
}