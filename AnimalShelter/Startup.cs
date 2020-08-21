using AnimalShelter.Models;
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
using Okta.AspNet;



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
      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      .AddJwtBearer(options =>
      {
        options.Authority = "https://dev-301956.okta.com/oauth2/default";
        options.Audience = "localhost//:5004";
        options.RequireHttpsMetadata = false;
      });

      services.AddDbContext<AnimalShelterContext>(opt =>
          opt.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
          b => b.MigrationsAssembly(typeof(AnimalShelterContext).Assembly.FullName)));
      services.AddDbContext<AnimalShelterContext>(opt =>
          opt.UseInMemoryDatabase("AnimalShelter"));
      services.AddSwaggerGen();
      services.AddHttpContextAccessor();
      services.AddSingleton<IUriService>(o =>
      {
        var accessor = o.GetRequiredService<IHttpContextAccessor>();
        var request = accessor.HttpContext.Request;
        var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
        return new UriService(uri);
      });
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      // app.UseOktaWebApi(new OktaWebApiOptions()
      // {
      //   OktaDomain = "https://dev-301956.okta.com/oauth2/default",
      // });
      app.UseSwagger();
      app.UseSwaggerUI(c =>
    {
      c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
      c.RoutePrefix = string.Empty;

    });
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();

      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      // app.UseHttpsRedirection();
      app.UseAuthentication();
      app.UseMvc();
    }
  }
}
