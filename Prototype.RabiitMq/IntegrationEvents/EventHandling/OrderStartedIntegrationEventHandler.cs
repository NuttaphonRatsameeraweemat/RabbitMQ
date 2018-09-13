using Prototype.RabbitMq.EventBus.Abstractions;
using Prototype.RabiitMq.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.RabiitMq.IntegrationEvents.EventHandling
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {
        public async Task Handle(OrderStartedIntegrationEvent @event)
        {
            File.WriteAllText(@"D:/rabbitMQ.txt", @event.Message);
        }
    }
}
