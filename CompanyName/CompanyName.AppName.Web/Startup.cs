using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Data;
using CompanyName.AppName.Web.Infrastructure;
using CompanyName.AppName.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using Reusable.Business.Core;
using Reusable.Data.Abstractions;
using Reusable.Data.Core;

namespace CompanyName.AppName.Web
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
            services.AddLocalization(options => { options.ResourcesPath = "Resources"; });
            services.AddControllersWithViews()
                .AddViewLocalization(options => { options.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization(
                options => options.DataAnnotationLocalizerProvider = (type, factory) =>
                {
                    return factory.Create(typeof(Labels));
                }
                );

            //registering db context services, note that the connection string is the one inside appsettings.json file
            services.AddScoped<DbContext, AppDbContext>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AppDbConnection")));

            //registering unitOfWork services
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //registering IRepository services using GenericRepository because all other repositories inherit from it
            services.AddTransient(typeof(IRepository<,>), typeof(GenericRepository<,>));

            //registering businessServices 
            services.AddTransient(typeof(GenericBusinessService<,>));
            services.AddTransient<PersonBusinessService>();
            services.AddTransient(typeof(ReferentielBusinessService<,>));

            //registering ActivityApiService
            services.AddHttpClient<ActivityApiService>();

            //registering AppSettings services
            AppSettings appSettings = Configuration.GetSection(nameof(appSettings)).Get<AppSettings>();
            services.AddSingleton(appSettings);

            //registering ApiServicesUrls
            services.AddSingleton(new ApiServicesUrls(appSettings));

            services.AddCors(o => {
                o.AddDefaultPolicy(p =>
                {
                    p.AllowAnyOrigin();
                    p.AllowAnyMethod();
                    p.AllowAnyHeader();
                });
            });


            //Configuring LocalizationOptions to use ResourcesPath "Resources" in Web project
            services.Configure<LocalizationOptions>(options => { options.ResourcesPath = "Resources"; });

            var cultures = new List<CultureInfo>
                {
                    //new CultureInfo("ar"),                    
                    new CultureInfo("en-US"),
                    new CultureInfo("fr-FR")
                };

            //Configuring RequestLocalizationOptions
            services.Configure<RequestLocalizationOptions>(options =>
            {
                //TODO: Set the SupportedCultures list
                options.SupportedCultures = cultures;

                //TODO: Set SupportedUICultures list
                options.SupportedUICultures = cultures;

                //TODO: Define DefaultRequestCulture to be fr-FR
                options.DefaultRequestCulture = new RequestCulture("fr-FR");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //add RequestLocalization middleware
            app.UseRequestLocalization();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
