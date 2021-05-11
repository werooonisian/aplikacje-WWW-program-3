using aplikacje_WWW_program_3.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_program_3
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
            //obs³uguje kontekst naszej bazy danych
            services.AddDbContext<ContextClass>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("FizzBuzzBD"));
            });
            services.AddRazorPages();
            services.AddDistributedMemoryCache(); //DODANE, do zapisu wiêkszych formacji

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(1000); //czas (podany w sekundach) a¿ sesja wygaœnie
                options.Cookie.HttpOnly = true; //okreœla, czy pliki cookie s¹ dostêpne po stronie klienta
                options.Cookie.IsEssential = true; //okreœla, czy plik cookie jest istotny do poprawnego dzia³ania
                                                   //aplikacji, domyœlnie jest ustawione na false.
                                                   //Kiedy jest true - sparwdzane s¹ zasady zgody
            });  //dodatkowe parametry

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); //grrr
            app.UseAuthorization();

            app.UseSession(); //DODANE, musi znajdowaæ siê przed UseEndpoints();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
