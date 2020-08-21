﻿using AnimalShelter.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AnimalShelter.Helpers;
using AnimalShelter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace AnimalShelter
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
      // services.AddCors(options =>
      // {
      //   options.AddDefaultPolicy(
      //         builder =>
      //         {
      //           builder.WithOrigins("http://example.com", "https://localhost:5001");
      //         });

      // });

      // services.Configure<CookiePolicyOptions>(options =>
      // {
      //   // This lambda determines whether user consent for non-essential cookies is needed for a given request.
      //   options.CheckConsentNeeded = context => true;
      //   options.MinimumSameSitePolicy = SameSiteMode.None;
      // });

      services.AddDbContext<AnimalShelterContext>(opt =>
          opt.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
          b => b.MigrationsAssembly(typeof(AnimalShelterContext).Assembly.FullName)));
      services.AddHttpContextAccessor();
      services.AddSingleton<IUriService>(o =>
      {
        var accessor = o.GetRequiredService<IHttpContextAccessor>();
        var request = accessor.HttpContext.Request;
        var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
        return new UriService(uri);
      });
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      // var appSettingsSection = Configuration.GetSection("AppSettings");
      // services.Configure<AppSettings>(appSettingsSection);

      // configure jwt authentication
      // var appSettings = appSettingsSection.Get<AppSettings>();
      // var key = Encoding.ASCII.GetBytes(appSettings.Secret);
      // services.AddAuthentication(x =>
      // {
      //   x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
      //   x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      // })
      // .AddJwtBearer(x =>
      // {
      //   x.RequireHttpsMetadata = false;
      //   x.SaveToken = true;
      //   x.TokenValidationParameters = new TokenValidationParameters
      //   {
      //     ValidateIssuerSigningKey = true,
      //     IssuerSigningKey = new SymmetricSecurityKey(key),
      //     ValidateIssuer = false,
      //     ValidateAudience = false
      //   };
      // });

      // configure DI for application services
      services.AddScoped<IUserService, UserService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {

      // app.UseAuthentication();
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();

      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      // app.UseCors();
      // app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
