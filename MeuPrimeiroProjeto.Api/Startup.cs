using MeuPrimeiroProjeto.BLL;
using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.DAL;
using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MeuPrimeiroProjeto.Api
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
            //CONTEXTO
            services.AddScoped<MeuPrimeiroProjetoDbContext>();

            //REPOSITORY
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IRestauranteRepository, RestauranteRepository>();

            //BLL
            services.AddScoped<ILoginBLL, LoginBLL>();
            services.AddScoped<IRestauranteBLL, RestauranteBLL>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
