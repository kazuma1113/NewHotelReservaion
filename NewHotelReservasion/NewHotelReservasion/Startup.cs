using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewHotelReservasion.Startup))]
namespace NewHotelReservasion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
