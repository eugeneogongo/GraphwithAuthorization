using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLWithAuthorization.JWT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GraphQLWithAuthorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IConfiguration config;

        public LoginController(IConfiguration configuration)
        {
            this.config = configuration;
        }
        public IActionResult Index()
        {
            var jwt = new JWTGenerator(config);
            return Content(jwt.GenerateSecurityToken("me@gmail.com"));

        }
    }
}