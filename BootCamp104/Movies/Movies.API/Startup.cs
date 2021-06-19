using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Movies.Business;
using Movies.Business.Extensions;
using Movies.DataAccess.Data;
using Movies.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.API
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
            services.AddControllers(opt =>
            {
                opt.CacheProfiles.Add("list", new CacheProfile { Duration = 300 });
            });
                    
            services.AddResponseCaching();
            services.AddMemoryCache();
            //Cache mekanizmasını sunucu üzerinde dağıtmak da mümkün:
            services.AddDistributedRedisCache(opt =>
            {
                opt.Configuration = "genre_list:6379";
            });

            //Redis Dependency Injection:
            services.Add(ServiceDescriptor.Singleton<IDistributedCache, RedisCache>());

            services.AddMapperConfiguration();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IGenreRepository, EFGenreRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, FakeUserRepository>();
            var connectionString = Configuration.GetConnectionString("db");
            services.AddDbContext<MoviesDbContext>(option => option.UseSqlServer(connectionString));

            services.AddSwaggerGen(option => option.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Dokümanın başlığı",
                Contact = new OpenApiContact
                {
                    Email = "humeyra.benli@gmail.com",
                    Name = "Hümeyra"
                },
                Version ="v1"
            }));

            //denetleme
            var issuer = Configuration.GetSection("Bearer")["Issuer"];
            var audience = Configuration.GetSection("Bearer")["Audience"];
            var key = Configuration.GetSection("Bearer")["SecurityKey"];
            
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(opt =>
                    {
                        opt.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidateActor = true,
                            ValidateAudience = true,
                            ValidateIssuer = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = issuer,
                            ValidAudience = audience,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                        };
                    });


            //Cross origin requests
            /*
             *   -- Aynı originler:
             *   https://www.turkayurkmez.com/index.html
             *   https://www.turkayurkmez.com/posts.php
             *   
             *   -- Farklı orjinler:
             *   https://www.turkayurkmez.com/index.html
             *   https://info.turkayurkmez.com
             *   http://www.turkayurkmez.com/index.html
             *   https://www.turkayurkmez.com:1444/index.html
             */


            services.AddCors(opt =>
            {
                opt.AddPolicy("Allow", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });


            });

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseSwagger();
            app.UseSwaggerUI(opt => opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Movies.API"));

            app.UseHttpsRedirection();

            app.UseRouting();       
            app.UseCors("Allow");
            app.UseResponseCaching();
            
            app.UseAuthentication();
            app.UseAuthorization();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
