using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaController : ControllerBase
    {
        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] CalculaModel data)
        {
            try
            {
                if (data.ValorInicial <= 0 || data.PrazoMes <= 1)
                {
                    return BadRequest("Invalid values.");
                }

                ResponseModel resultado = CalculaCDB.Calcular(data.ValorInicial, data.PrazoMes);

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}