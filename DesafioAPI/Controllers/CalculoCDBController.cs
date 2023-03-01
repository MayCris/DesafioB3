using Microsoft.AspNetCore.Mvc;

namespace DesafioAPI.Controllers
{
    [ApiController]
    [Route("[calculocdb]")]

    public class CalculoCDBController : ControllerBase
    {
        private readonly ILogger<CalculoCDBController> _logger;

        public CalculoCDBController(ILogger<CalculoCDBController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCalculoCDB")]
        public CdbRetorno Get(decimal valorAplicado, int meses)
        {
            CdbRetorno retorno = new CdbRetorno();
            retorno.CalcularValores(valorAplicado, meses);

            return retorno;
        }
    }
}
