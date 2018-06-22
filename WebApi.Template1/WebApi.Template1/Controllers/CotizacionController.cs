using System.Net;
using System.Web.Http;

namespace WebApi.Test.Controllers
{
    public class CotizacionController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get([FromUri] string param)
        {
            return ServiceFactory(param);
        }

        private IHttpActionResult ServiceFactory(string param)
        {
            switch(param.ToLower())
            {
                case "pesos":
                    return NoAutorizado();
                case "real":
                    return NoAutorizado();
                case "dolar":
                    return BancoProvinciaDolarService();
                default:
                    throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        private IHttpActionResult NoAutorizado()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        private IHttpActionResult BancoProvinciaDolarService()
        {
            return Redirect("http://www.bancoprovincia.com.ar/Principal/Dolar");
        }
    }
}
