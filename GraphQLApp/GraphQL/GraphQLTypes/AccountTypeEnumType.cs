using GraphQL.Types;
using GraphQLApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.GraphQL.GraphQLTypes
{
    public class AccountTypeEnumType : EnumerationGraphType<TypeOfAccount>
    {
        public AccountTypeEnumType()
        {
            Name = "Type"; //Must match the property name of model that is Account in this case.
            Description = "Enumeration for the account type object.";
        }
    }
}
