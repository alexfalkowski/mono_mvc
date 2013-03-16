namespace Mvc.Controllers
{
    using System.Web.Http;

    public class ServiceController : ApiController
    {
        public string GetTest()
        {
            return "awesome";
        }
    }
}
