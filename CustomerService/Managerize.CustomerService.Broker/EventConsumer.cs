using Confluent.Kafka;
using System;
using System.Threading;

namespace Managerize.CustomerService.Broker
{
    public class EventConsumer : IEventConsumer
    {
        public string ConsumeEvent()
        {
            var conf = new ConsumerConfig
            {
                GroupId = "test-consumer-group",
                BootstrapServers = "localhost:9092",

                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            string msg = "";

            using (var c = new ConsumerBuilder<Ignore, string>(conf).Build())
            {
                c.Subscribe("managerize-customer-topic");

                CancellationTokenSource cts = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) => {
                    e.Cancel = true;
                    cts.Cancel();
                };

                try
                {
                    try
                    {
                        var cr = c.Consume(cts.Token);
                        Console.WriteLine($"Consumed message '{cr.Value}' at: '{cr.TopicPartitionOffset}'.");
                        msg = cr.Value;
                    }
                    catch (ConsumeException e)
                    {
                        Console.WriteLine($"Error occured: {e.Error.Reason}");
                    }
                }
                catch (OperationCanceledException)
                {
                    c.Close();
                }

                return msg;
            }
        }
    }
}
