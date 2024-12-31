using MediatR;

namespace CarRental.Domain.Base
{
    public class DomainEvent: INotification
    {
        public Guid Id { get; }

        public DomainEvent()
        {
            Id = Guid.NewGuid();
        }
    }
}
