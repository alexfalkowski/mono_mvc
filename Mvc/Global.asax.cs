namespace Mvc
{
    using System.Web;
    using Mvc.Configuration;

    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiApplication.RegisterApplication();
            MvcApplication.RegisterApplication();
        }
    }
}
