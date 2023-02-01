using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSRS.Services.ModelContracts;

namespace GSRS.Services.Models
{
    public class BaseModel:IBaseModel
    {
        public int id{get;set;}

        public DateTime DateCreated {get;set;}

        public DateTime DateChanged {get;set;}
        public String ChangedBy {get;set;}
    }
}