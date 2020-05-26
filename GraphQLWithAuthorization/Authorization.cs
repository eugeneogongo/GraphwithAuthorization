using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GraphQLWithAuthorization
{
    public static class Authorization
    {
        public static bool CheckClaims(this ResolveFieldContext<Object> context,string claims)
        {
            var user = context.UserContext as ClaimsPrincipal;

            return user.IsInRole(claims);
        }

    }
}
