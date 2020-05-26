using GraphQL.Types;
using GraphQLWithAuthorization.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWithAuthorization.GraphQL
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t=>t.Id);
            Field(t => t.Name);

        }
    }
}
