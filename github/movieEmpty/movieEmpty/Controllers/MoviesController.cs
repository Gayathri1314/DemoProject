using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace movieEmpty.Controllers
{
    public class MoviesController : ApiController
    {
        public string Get()
        {
            return "Hello from Web API";
        }
    }
}
