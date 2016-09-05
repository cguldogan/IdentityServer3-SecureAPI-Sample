using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using IdentityServer3.AccessTokenValidation;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using SecureAPISample.App_Start;

[assembly: OwinStartup(typeof(SecureAPISample.Startup))]

namespace SecureAPISample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://10.10.27.36:4044", //Your Identity Server address

            });

            var config = new HttpConfiguration();
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
            WebApiConfig.Register(config);
            app.UseWebApi(config);

        }
    }
}
