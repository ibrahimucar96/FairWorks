using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI
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
            services.AddControllersWithViews();

            services.AddDbContext<FairWorksDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("db")));
            services.AddScoped<IBiletliZiyaretciManager,BiletliZiyaretciManager>();
            services.AddScoped<IDavetiyesizZiyaretciManager,DavetiyesizZiyaretciManager>();
            services.AddScoped<IDovizManager,DovizManager>();
            services.AddScoped<IFirmaManager,FirmaManager>();
            services.AddScoped<IFirmaBilgiManager,FirmaBilgiManager>();
            services.AddScoped<IFirmaTipiManager,FirmaTipiManager>();
            services.AddScoped<IFirmaTipveFirmaManager,FirmaTipveFirmaManager>();
            services.AddScoped<IGorusulenFirmaManager,GorusulenFirmaManager>();
            services.AddScoped<IIlaveStandMalzemeleriManager,IlaveStandMalzemeleriManager>();
            services.AddScoped<IKatalogGirisFormManager,KatalogGirisFormManager>();
            services.AddScoped<IKullaniciManager,KullaniciManager>();
            services.AddScoped<IOdemePlaniManager,OdemePlaniManager>();
            services.AddScoped<IPersonelManager,PersonelManager>();
            services.AddScoped<IPotansiyelFirmaManager,PotansiyelFirmaManager>();
            services.AddScoped<ISalonManager,SalonManager>();
            services.AddScoped<ISozlesmeBilgisiManager,SozlesmeBilgisiManager>();
            services.AddScoped<ISozlesmeTipiManager,SozlesmeTipiManager>();
            services.AddScoped<IStandManager,StandManager>();
            services.AddScoped<ITedarikciManager,ITedarikciManager>();
            services.AddScoped<ITeklifBilgisiManager,TeklifBilgisiManager>();
            services.AddScoped<ITemsilEttigiFirmaManager,TemsilEttigiFirmaManager>();
            services.AddScoped<IUrunManager,UrunManager>();
            services.AddScoped<IZiyaretciManager,ZiyaretciManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
