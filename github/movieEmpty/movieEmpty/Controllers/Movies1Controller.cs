using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace movieEmpty.Controllers
{
    public class Movies1Controller : ApiController
    {
        public List<string> GetMovies()
        {
            return new List<string> { "Titanic", "Mission", "Impossible", "Matrix" }; 
        }
    }
}
