using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewHotelReservesion.Startup))]
namespace NewHotelReservesion
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
