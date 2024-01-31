using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionState_MSSQL.Startup))]
namespace SessionState_MSSQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
