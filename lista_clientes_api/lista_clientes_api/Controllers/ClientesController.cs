using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace lista_clientes_api.Controllers
{
    [Route("clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        [Route("")]
        public List<Cliente> Index()
        {
            return Cliente.Todos();
        }

        [HttpPost]
        [Route("criar")]
        public Cliente Criar([FromBody] Cliente cliente)
        {
            return cliente.Salvar();
        }

        [HttpPut]
        [Route("{id}")]
        public Cliente Atualizar(int id, [FromBody] Cliente cliente)
        {
            cliente.Id = id;
            return cliente.Salvar();
        }
    }
}
