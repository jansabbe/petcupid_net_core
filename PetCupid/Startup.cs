using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Webpack;

namespace PetCupid
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddWebpack();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
            //if (env.IsDevelopment()) {
                loggerFactory.AddConsole();
                app.UseDeveloperExceptionPage();
                app.UseWebpack("webpack.config.js", "appBundle.js");    
            //}
            
        }

        // Entry point for the application.
        public static void Main(string[] args) {
            WebApplication.Run<Startup>(args);
        }
    }
}
