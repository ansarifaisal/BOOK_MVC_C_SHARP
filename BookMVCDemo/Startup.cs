using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMVCDemo.Startup))]
namespace BookMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
