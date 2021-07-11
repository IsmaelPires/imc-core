using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using IMC.Aplicacao;
using IMC.Infra.Data.Contextos;
using IMC.Infra.IoC;
using AutoMapper;
using System;

namespace IMC.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Contexto>(o => o.UseMySql(Configuration.GetConnectionString("Usuario"), new MySqlServerVersion(new Version(8, 0, 25))));
            InjetorDependencias.Registrar(services);
            services.AddAutoMapper(x => x.AddProfile(new MappingEntidade()));
            //services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllers(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews(options => options.EnableEndpointRouting = false);
            services.AddRazorPages().AddMvcOptions(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
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