using System.ComponentModel.DataAnnotations.Schema;

namespace NimblePros.SharedKernel;

public abstract class HasDomainEventsBase : IHasDomainEvents
{
  private readonly List<DomainEventBase> _domainEvents = new();
  [NotMapped]
  public IReadOnlyCollection<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

  public void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
  public void ClearDomainEvents() => _domainEvents.Clear();
}
