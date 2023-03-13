using System.Configuration;
using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace TC.SelfHostedAPISample
{
    public partial class APIService : ServiceBase
    {
        HttpSelfHostServer httpSelfHostServer;
        public APIService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration(ConfigurationManager.AppSettings["SelfHostAPIUrl"]);
            config.Routes.MapHttpRoute(
                name: "SelfHostAPI",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //Example: http://localhost:8080/Values/GetString/5
            if (httpSelfHostServer == null)
            {
                httpSelfHostServer = new HttpSelfHostServer(config);
                httpSelfHostServer.OpenAsync().Wait();
            }
        }

        protected override void OnStop()
        {
            httpSelfHostServer.CloseAsync().Wait();
        }
    }
}
