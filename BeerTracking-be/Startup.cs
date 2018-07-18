using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerTracking_be.Application;
using BeerTracking_be.Data.Beers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoCrud.Data;
using MongoCrud.Data.Breweries;
using MongoCrud.Domain.Beers;
using MongoCrud.Domain.Breweries;

namespace BeerTracking_be
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
            services.AddMvc();

            // Left side = what type is being requested
            // Right side = what type to create an instance of and provide back
            services.AddTransient<BaseRepo<Beer>, BeerRepo>();

            // Left side = what type is being requested
            // Right side = what type to create an instance of and provide back
            services.AddTransient<BaseRepo<Brewery>, BreweryRepo>();

            services.AddTransient<BaseManager<Brewery>, BreweryManager>();
            services.AddTransient<BaseManager<Beer>, BeerManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
