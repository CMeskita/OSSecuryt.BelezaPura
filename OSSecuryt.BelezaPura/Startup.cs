using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OSSecuryt.BelezaPura.Domain.Interfaces;
using OSSecuryt.BelezaPura.Infra.Data.DbSqlServer;
using OSSecuryt.BelezaPura.Infra.Repository;
using OSSecuryt.BelezaPura.Infra.UnitOfWork;
using OSSecuryt.BelezaPura.Servico.Efeito.Commands;
using OSSecuryt.BelezaPura.Servico.Efeito.Handler;
using OSSecuryt.BelezaPura.Servico.Servico.Commands;
using OSSecuryt.BelezaPura.Servico.Servico.Handler;
using OSSecuryt.BelezaPura.Servico.Util;

namespace OSSecuryt.BelezaPura
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
            services.AddMediatR(typeof(EfeitosHandler));
            services.AddDbContext<SqlServerContext>(opt => opt.UseSqlServer("name=ConnectionStrings:Sql"));
            services.AddTransient<IRequestHandler<EfeitosCommand,Response>,EfeitosHandler>();
            services.AddTransient<IEfeitosRepository, EfeitosRepository>();
            services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddMediatR(typeof(ServicosHandler));
            services.AddTransient<IRequestHandler<ServicosCommand, Response>, ServicosHandler>();
            services.AddTransient<IServicosRepository, ServicosRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
