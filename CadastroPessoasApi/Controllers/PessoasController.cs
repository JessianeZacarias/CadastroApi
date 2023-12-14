using CadastroPessoasApi.Service;
using CadastroPessoasApi.ViewModel;
using Dapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CadastroPessoasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
      
        [HttpGet("GetAll")]
        public IEnumerable<PessoaViewModel> GetAll()
        {
            var service = new ServicePessoa();

            var result = service.GetAll();
            return result;
        }
        [HttpGet("GetById/{pessoaId}")]
        public PessoaViewModel GetById(int pessoaId)
        {
            var service = new ServicePessoa();
            return service.GetById(pessoaId);
        }
        [HttpGet("GetByPrimeiroNome/{primeiroNome}")]
        public PessoaViewModel GetByPrimeiroNome(string primeiroNome)
        {
            var service = new ServicePessoa();
            return service.GetByPrimeiroNome(primeiroNome);
        }
        [HttpPut("Update/{pessoaId}by{primeiroNome}")]

        public void Update(int pessoaId, string primeiroNome)
        {
            var service = new ServicePessoa();
            service.Update(pessoaId, primeiroNome);
        }
        [HttpPost("Create")]

        public ActionResult Create(PessoaViewModel pessoa)
        {
            var service = new ServicePessoa();
            var resultado = service.Create(pessoa);

            var result = new
            {
              Sucess = true,
              Data = resultado,
            };
            return Ok(result);
        }
        [HttpDelete("Delete")]

        public void Delete(int pessoaId)
        {
            var service = new ServicePessoa();
            service.Delete (pessoaId);
        }

            
    } 
}
