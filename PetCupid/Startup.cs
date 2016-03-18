using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Webpack;
using PetCupid.Repositories;
using PetCupid.Database;

using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;

namespace PetCupid
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["Production:PetsDatabase"];

            services.AddEntityFramework()
                .AddSqlite()
                .AddDbContext<PetsDbContext>(options => options.UseSqlite(connection));

            services.AddMvc();
            services.AddWebpack();
            services.AddSwaggerGen();
            services.AddTransient<Pets>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
            //if (env.IsDevelopment()) {
            loggerFactory.AddConsole();
            
            app.UseSwaggerGen();
            app.UseSwaggerUi();
            
            app.UseWebpack("webpack.config.js", "appBundle.js");
            
                    
            //}

        }

        // Entry point for the application.
        public static void Main(string[] args)
        {
            WebApplication.Run<Startup>(args);
        }
    }
}
