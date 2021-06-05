using AboutMiddleware.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMiddleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //http request üzerinde yapılacak işlemleri çaıştıran kısımlar middleware, bunların çalışma sırası ise pipeline idi..
            /*
             *  Request editing
             *  Response editing
             *  Content editing             *  
             */


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //1. Run: diğer middleware'leri çalıştırma:
            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    await context.Response.WriteAsync("Talep sunucuya ulasti");
            //});
            //Sadece belirtilmiş adrese (/test) gittiğinde middleware çalışsın 
            app.Map("/test", builder =>
             {
                 builder.Run(async (context) =>
                 {
                     if (context.Request.Query.ContainsKey("id"))
                     {
                         await context.Response.WriteAsync("Test talebi geldi. Gelen deger: " + context.Request.Query["id"]);
                     }
                     else
                     {
                         await context.Response.WriteAsync("Deger olmadıgından test edilemiyor. Ana sayfaya donun");
                     }
                 });
             });

            app.UseMiddleware<CheckforIE>();
           // app.UseWelcomePage();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
