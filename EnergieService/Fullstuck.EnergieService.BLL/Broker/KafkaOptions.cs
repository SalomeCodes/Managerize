using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fullstuck.EnergieService.BLL.Broker
{
    public class KafkaOptions
    {
        public string Topic { get; set; }

        public string[] Hosts { get; set; }

        public string GroupId { get; set; }

        public AutoOffsetReset AutoOffsetReset { get; set; }
    }
}
