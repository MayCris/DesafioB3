using Microsoft.AspNetCore.Mvc;

namespace DesafioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CalculoCDBController : ControllerBase
    {
        [HttpGet]
        public CdbRetorno GetCalculoCDB(decimal valorAplicacao, int meses)
        {
            CdbRetorno retorno = new CdbRetorno();
            retorno.CalcularValores(valorAplicacao, meses);

            return retorno;
        }
    }
}
