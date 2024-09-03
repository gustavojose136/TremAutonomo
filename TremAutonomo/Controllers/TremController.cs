using Microsoft.AspNetCore.Mvc;
using TremAutonomo.Models.Models;

namespace TremAutonomo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TremController : ControllerBase
    {
        [HttpGet("TESTE")]
        public IActionResult Index()
        {
            return Ok("API está funcionando");
        }

        [HttpGet()]
        public IActionResult PosicaoTrem() {
            var train = new TremModel();
            var result = train.GetPosicao();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult ExecutarComandos(List<string> comandos)
        {
            var train = new TremModel();
            var result = train.ExecutarComandos(comandos);

            return Ok(new
            {
                Mensagem = result,
                PosicaoFinal = train.Position
            });
        }
    }
}
