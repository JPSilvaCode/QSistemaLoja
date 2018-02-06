using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QSistemaLoja.Startup))]
namespace QSistemaLoja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
