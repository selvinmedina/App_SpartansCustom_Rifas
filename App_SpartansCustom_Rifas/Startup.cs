using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_SpartansCustom_Rifas.Startup))]
namespace App_SpartansCustom_Rifas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
