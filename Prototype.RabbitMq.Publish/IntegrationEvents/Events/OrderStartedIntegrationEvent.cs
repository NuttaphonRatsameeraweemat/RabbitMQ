using Prototype.RabbitMq.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.RabbitMq.Publish.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {
        public string Message { get; private set; }

        public OrderStartedIntegrationEvent(string message) => Message = message;
    }
}
