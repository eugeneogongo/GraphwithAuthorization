using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWithAuthorization.GraphQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<ProductQuery>();
        }
    }
}
