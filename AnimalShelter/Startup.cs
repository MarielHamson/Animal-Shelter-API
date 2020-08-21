﻿using AnimalShelter.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AnimalShelter.Services;
using Microsoft.AspNetCore.Http;


namespace AnimalShelter
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddCors(options =>
        {
          options.AddPolicy(MyAllowSpecificOrigins,
          builder =>
          {
            builder.WithOrigins("http://example.com",
                                  "http://www.google.com")
                                  .AllowAnyHeader()
                                  .AllowAnyMethod();
          });
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

      app.UseCors(MyAllowSpecificOrigins);
      // app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
