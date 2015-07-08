using System.Web;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace OperatorStatusList
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
                .ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
