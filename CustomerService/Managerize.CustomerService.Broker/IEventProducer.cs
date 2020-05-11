using System.Threading.Tasks;

namespace Managerize.CustomerService.Broker
{
    public interface IEventProducer
    {
        public Task ProduceEvent();
    }
}
