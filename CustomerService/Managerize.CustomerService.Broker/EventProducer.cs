using Confluent.Kafka;
using System;
using System.Threading.Tasks;

namespace Managerize.CustomerService.Broker
{
    public class EventProducer : IEventProducer
    {
        private readonly ProducerConfig _config; 
        public EventProducer()
        {
            _config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        }

        public async Task ProduceEvent()
        {
            using (var p = new ProducerBuilder<Null, string>(_config).Build())
            {
                try
                {
                    var dr = await p.ProduceAsync("managerize-customer-topic", new Message<Null, string> { Value = "Nieuwe klant pietje is toegevoegd" });
                    Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
    }
}
