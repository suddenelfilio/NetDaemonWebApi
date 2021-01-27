using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace daemonapp.apps.HelloWorld
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /* configure any services you need here */
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            // Output a "hello world" to the user who accesses the server
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello, world!");
            });
        }
    }
}
