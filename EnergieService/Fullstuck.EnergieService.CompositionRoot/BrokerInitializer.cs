using Confluent.Kafka;
using Fullstuck.EnergieService.BLL.Broker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstuck.EnergieService.CompositionRoot
{
    public class BrokerInitializer
    {
    
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            var kafkaOptions = new KafkaOptions();
            string stage = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (stage != "Development")
            {
                kafkaOptions.Hosts = string.Join(",", Environment.GetEnvironmentVariable("ENERGIE_KAFKA_HOST")).Split(",");
                kafkaOptions.Topic = Environment.GetEnvironmentVariable("ENERGIE_KAFKA_TOPIC");
                kafkaOptions.GroupId = Environment.GetEnvironmentVariable("ENERGIE_KAFKA_GROUPID");
                kafkaOptions.AutoOffsetReset = (AutoOffsetReset)Enum.Parse(typeof(AutoOffsetReset), Environment.GetEnvironmentVariable("ENERGIE_KAFKA_OFFSET"), true);
            }

            switch (stage)
            {
                case "Development":
                    services.Configure<KafkaOptions>(x => configuration.GetSection("kafka").Bind(x));
                    break;
                case "Docker":
                    services.Configure<KafkaOptions>(x =>
                    {
                        x.Hosts = kafkaOptions.Hosts;
                        x.Topic = kafkaOptions.Topic;
                        x.GroupId = kafkaOptions.GroupId;
                        x.AutoOffsetReset = kafkaOptions.AutoOffsetReset;
                    });
                    break;
                case "Production":
                    services.Configure<KafkaOptions>(x => { x = kafkaOptions; });
                    break;
                default:
                    break;
            }

            services.AddHostedService<KafkaConsumer>();
        }
    }
}
