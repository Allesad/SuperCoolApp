using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SuperCoolApp.Controllers
{
    [Route("/api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new []
            {
                "Hello",
                "World"
            };
        }
    }
}