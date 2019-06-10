using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectroBackend.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ElectroBackend
{
    public class Startup
    {
        const string CORS_STRING = "_electroAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddCors(options => options.AddPolicy(CORS_STRING, builder => { builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }));
            services.AddEntityFrameworkSqlServer().AddDbContext<ElectroBackend.Models.ElectroApiContext>(opt => {
                opt.UseSqlServer("Data Source=localhost,32768;Initial Catalog=ElectroDb;User ID=sa;Password=7e530f4babc");
                opt.UseLazyLoadingProxies();
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                   .AddJwtBearer(options =>
                   {
                       options.RequireHttpsMetadata = false;
                       options.TokenValidationParameters = new TokenValidationParameters
                       {
                            ValidateIssuer = true,
                            ValidIssuer = AuthOptions.ISSUER,
                            ValidateAudience = true,
                            ValidAudience = AuthOptions.AUDIENCE,
                            ValidateLifetime = false,
                            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                            ValidateIssuerSigningKey = true,
                       };
                   });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);



        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           app.UseDefaultFiles();
           
           app.UseStaticFiles(); 
            app.UseHsts();
            app.UseAuthentication();
            app.UseCors(CORS_STRING);
           
            app.UseMvc();
            
        }
    }
}
