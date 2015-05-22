using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using TodoApi.Models;

namespace mvc6
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<ITodoRepository, TodoRepository>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseWelcomePage();
           
        }
    }
}
