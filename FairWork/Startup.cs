using FairWorks.BLManager.Abstract;
using FairWorks.BLManager.Concrete;
using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWork
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

            
            //Iliþkili kayitlarin EntityFrameWork icerisinde gelebilmesi icin 
            // Bu ayarin eklenmesi gerekmektedir.
            // Bundan once Microsoft.ASPNetCore.MVC.NewtonSoftJson paketinin
            //Kurulu olmasi gerekmektedir
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //SQL Connection saðlandý
            services.AddDbContext<FairWorksDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("db")));
            //Manager services eklendi
            services.AddScoped<IBiletliZiyaretciManager, BiletliZiyaretciManager>();
            services.AddScoped<IDavetiyesizZiyaretciManager, DavetiyesizZiyaretciManager>();
            services.AddScoped<IDovizManager, DovizManager>();
            services.AddScoped<IFirmaManager, FirmaManager>();
            services.AddScoped<IFirmaTipiManager, FirmaTipiManager>();
            services.AddScoped<IFirmaTipveFirmaManager, FirmaTipveFirmaManager>();
            services.AddScoped<IGorusulenFirmaManager, GorusulenFirmaManager>();
            services.AddScoped<IIlaveStandMalzemeleriManager, IlaveStandMalzemeleriManager>();
            services.AddScoped<IKatalogGirisFormManager, KatalogGirisFormManager>();
            services.AddScoped<IKullaniciManager, KullaniciManager>();
            services.AddScoped<IOdemePlaniManager, OdemePlaniManager>();
            services.AddScoped<IPersonelManager, PersonelManager>();
            services.AddScoped<IPotansiyelFirmaManager, PotansiyelFirmaManager>();
            services.AddScoped<ISalonManager, SalonManager>();
            services.AddScoped<ISozlesmeBilgisiManager, SozlesmeBilgisiManager>();
            services.AddScoped<ISozlesmeTipiManager, SozlesmeTipiManager>();
            services.AddScoped<IStandManager, StandManager>();
            services.AddScoped<ITedarikciManager, TedarikciManager>();
            services.AddScoped<ITeklifBilgisiManager, TeklifBilgisiManager>();
            services.AddScoped<ITemsilEttigiFirmaManager, TemsilEttigiFirmaManager>();
            services.AddScoped<IUrunManager, UrunManager>();
            services.AddScoped<IZiyaretciManager, ZiyaretciManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FairWork", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FairWork v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
