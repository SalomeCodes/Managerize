using Confluent.Kafka;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fullstuck.EnergieService.BLL.Broker
{
    public class KafkaConsumer : BackgroundService
    {
        private ConsumerConfig consumerConfig;
        private readonly KafkaOptions _kafkaOptions;
        private IConsumer<Ignore, string> consumer;

        public KafkaConsumer(IOptions<KafkaOptions> options)
        {
            _kafkaOptions = options.Value;
            init();
        }

        private void init()
        {
            //neede to implement the usage of the kafkaOptions
            consumerConfig = new ConsumerConfig
            {
                BootstrapServers = _kafkaOptions.Hosts.ToString(),
                GroupId = _kafkaOptions.GroupId,
                AutoOffsetReset = _kafkaOptions.AutoOffsetReset

            };

            consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();
            //select topic
            consumer.Subscribe(_kafkaOptions.Topic);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var result = consumer.Consume(stoppingToken);


            return Task.CompletedTask;
        }
    }
}
