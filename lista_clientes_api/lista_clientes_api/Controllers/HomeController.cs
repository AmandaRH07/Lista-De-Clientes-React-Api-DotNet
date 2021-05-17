using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_clientes_api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public Apresentacao Index()
        {
            return new Apresentacao();
        }
    }
}
