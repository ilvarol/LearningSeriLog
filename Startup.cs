using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSeriLog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Step 3: Adding MVC Design Pattern
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Step 2: Configure ASP.NET
            //UseDefaultFiles() should always be before UseStaticFiles().
            //This is because UseDefaultFiles rewrite the URLs.Use Static files only serves the URLs.
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //Step 4: Adding Endpoints
            //It should come after UseStaticFiles() because it takes over url re-rewriting 
            //UseRouting finds endpoint, UseEndpoints executes endpoints
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
