using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesSample.Web.Data;
using RazorPagesSample.Web.RouteConstraints;
using RazorPagesSample.Web.Services;

namespace RazorPagesSample.Web
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
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddRazorPagesOptions(options => 
                {
                    options.Conventions.AddPageRoute("/index", "home");
                    options.Conventions.AddPageRoute("/index", "start");
                });

            services.Configure<RouteOptions>(options => 
            {
                options.ConstraintMap.Add("promo", typeof(PromoConstraint));
            });

            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IBookService, BookService>();

            services.AddLogging();

            services.AddHealthChecks();

            services.AddDbContext<BookContext>(options =>
            {
               options.UseInMemoryDatabase("bookTestDb"); 
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // custom middleware for health check
            /* app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("health"))
                {
                    await context.Response.WriteAsync("App is healthy");
                }
                else
                {
                    await next.Invoke();
                }
            }); */

            app.UseHealthChecks("/health");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
