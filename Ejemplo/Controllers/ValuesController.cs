  
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ejemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Valor 1", "Valor 2" };
        }
    }
}
