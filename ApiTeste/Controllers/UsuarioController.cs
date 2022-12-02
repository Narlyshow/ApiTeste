using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()

            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}/{sobrenome}/{idade}")]
        public IActionResult Apresentar(string nome, string sobrenome, string idade)
        {
            var mensagem = $"Olá {nome} {sobrenome} {idade}, seja bem vindo!";
            return Ok(new { mensagem });
        }


    }
}
