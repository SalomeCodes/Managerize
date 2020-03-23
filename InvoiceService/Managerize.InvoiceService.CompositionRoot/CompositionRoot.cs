using Managerize.InvoiceService.BLL;
using Managerize.InvoiceService.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Managerize.InvoiceService.CompositionRoot
{
    public static class CompositionRoot
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();
            services.AddTransient<InvoiceContext>()
                .AddEntityFrameworkSqlServer()
                .AddDbContext<InvoiceContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("MANAGERIZE_INVOICE_SERVICE_DB")));
            
            services.AddTransient<InvoicesService>();
            services.AddTransient<CustomersService>();
            services.AddTransient<ItemsService>();
            services.AddTransient<IInvoiceLogic, InvoiceLogic>();

        }
    }
}
