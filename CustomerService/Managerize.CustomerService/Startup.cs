using Managerize.CustomerService.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using Managerize.CustomerService.Broker;

namespace Managerize.CustomerService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors();


            services.AddTransient<CustomersContext>()
                .AddDbContext<CustomersContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("MANAGERIZE_CUSTOMER_SERVICE_DB")));
            services.AddTransient<ICustomersService, CustomersService>();
            services.AddTransient<ICustomersService, CustomersService>();
            services.AddTransient<IEventProducer, EventProducer>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors(c => c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            //IEventProducer producer = new EventProducer();
            //producer.ProduceEvent();

            //IEventConsumer consumer = new EventConsumer();
            //var msg = consumer.ConsumeEvent();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Managerize - Customer service" + "Consumed event message is: " );
                });
            });
        }
    }
}
