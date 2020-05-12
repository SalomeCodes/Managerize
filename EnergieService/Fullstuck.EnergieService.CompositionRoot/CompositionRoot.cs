using Fullstuck.EnergieService.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Fullstuck.EnergieService.BLL;

namespace Fullstuck.EnergieService.CompositionRoot
{
    public static class CompositionRoot
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<EnergystuckContext>()
                .AddDbContext<EnergystuckContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("ENERGIESTUCK_ENERGIESERVICE_DB")));
            services.AddTransient<MetingenService>();
            services.AddTransient<IEnergieCalculationLogic, EnergieCalculationLogic>();
            services.AddTransient<IMetingenService, MetingenService>();
            services.AddTransient<IEnergieLogic, EnergieLogic>();
            services.AddTransient<IEnergiemeterLogic, EnergiemeterLogic>();
            services.AddTransient<IEnergiemeterMetingenService, EnergiemeterMetingenService>();
        }
    }
}
