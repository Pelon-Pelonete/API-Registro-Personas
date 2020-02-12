using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MediatR;
using MementoFX.Persistence;
using MementoFX.Persistence.SqlServer.Configuration;
using Rebus.ServiceProvider;
using Rebus.Routing.TypeBased;
using Personas.CommandStack.Events;
using Rebus.Config;
using Rebus.Serialization.Json;
using MementoFX.Messaging;
using MementoFX.Messaging.Rebus;

namespace Personas.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMediatR(typeof(Personas.CommandStack.Commands.RegistrarPersonaCommand));
            var connectionString = Configuration.GetConnectionString("EventStore");
            Settings settings = new Settings(connectionString, useSingleTable: true);
            services.AddSingleton(settings);
            services.AddTransient<IEventStore, MementoFX.Persistence.SqlServer.SqlServerEventStore>();
            services.AddTransient<IRepository, MementoFX.Persistence.Repository>();
            var queueName = Configuration["Rebus:QueueName"];
            services.AddRebus(config => config.Logging(l => l.Console(Rebus.Logging.LogLevel.Debug))// l.Trace())
                .Routing(r => r.TypeBased()
                    .MapAssemblyOf<PersonaRegistradaEvent>(queueName)
                )
                .Transport(t => t.UseRabbitMq(Configuration["Rebus:Transport:ConnectionString"], queueName))
                .Serialization(s => s.UseNewtonsoftJson(JsonInteroperabilityMode.PureJson))
                );

            services.AddTransient<IEventDispatcher, RebusEventDispatcher>();
            /*services.AutoRegisterHandlersFromAssemblyOf<PersonasDenormalizer>();

            var bus = services.BuildServiceProvider().GetRequiredService<IBus>();
            bus.Subscribe<PersonaRegistradaEvent>();*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
