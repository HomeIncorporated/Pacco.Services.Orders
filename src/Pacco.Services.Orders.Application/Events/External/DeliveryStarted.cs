using System;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace Pacco.Services.Orders.Application.Events.External
{
    [MessageNamespace("deliveries")]
    public class DeliveryStarted : IEvent
    {
        public Guid OrderId { get; }

        public DeliveryStarted(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}