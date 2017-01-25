using System.Web;
using System.Web.Http;
using Alex.Mimo.Test.BLL.Implementation;

namespace Alex.Mimo.Test
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FakeDataService.FillData();
        }
    }
}