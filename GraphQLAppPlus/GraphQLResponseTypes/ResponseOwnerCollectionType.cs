using GraphQLAppPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLAppPlus.GraphQL.GraphQLResponseTypes
{
    public class ResponseOwnerCollectionType
    {
        public List<Owner> Owners { get; set; }
    }
}
