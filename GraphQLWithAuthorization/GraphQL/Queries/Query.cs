using GraphQL;
using GraphQL.Types;
using GraphQLWithAuthorization.Data;
using GraphQLWithAuthorization.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace GraphQLWithAuthorization.GraphQL
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(ProductRepository repo)
        {

            Field<ListGraphType<ProductType>>("products","Returns a List of Products",
                resolve: context =>
                {
                    if (context.CheckClaims("admin"))
                    {
                        return repo.GetProducts();
                    }
                    context.Errors.Add(new ExecutionError("Not Authorized"));
                    return null;

                 
                }
               );
            Field<ProductType>("product", arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
            {
                Name = "id"
            }), resolve:context=>repo.GetById(context.GetArgument<int>("id")));
        }
    }
}
