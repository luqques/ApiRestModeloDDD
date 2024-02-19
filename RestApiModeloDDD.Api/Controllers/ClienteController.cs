using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dto;
using RestApiModeloDDD.Application.Interfaces;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _applicationServiceCliente.Delete(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}