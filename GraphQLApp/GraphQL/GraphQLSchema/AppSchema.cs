using GraphQL;
using GraphQL.Types;
using GraphQLApp.GraphQL.GraphQLQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApp.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
            Mutation = resolver.Resolve<AppMutation>();
        }
    }
}
