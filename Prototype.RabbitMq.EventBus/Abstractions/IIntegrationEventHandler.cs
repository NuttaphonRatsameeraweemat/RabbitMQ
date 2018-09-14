using Prototype.RabbitMq.EventBus.Events;
using System.Threading.Tasks;

namespace Prototype.RabbitMq.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);

        string HandleRpc(TIntegrationEvent @event);

    }

    public interface IIntegrationEventHandler
    {
    }
}
