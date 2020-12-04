using ClientPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPortal.ResponseTypes
{
    public class ResponseOwnerCollectionType
    {
        public List<Owner> Owners { get; set; }
    }
    public class ResponseOwnerType
    {
        public Owner Owner { get; set; }
    }
}
