namespace CarRental.Domain.Base
{
    public abstract class Entity 
    {
        private readonly List<DomainEvent> _domainEvents = new();
        public ICollection<DomainEvent> DomainEvents => _domainEvents;

        public void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
        
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}
