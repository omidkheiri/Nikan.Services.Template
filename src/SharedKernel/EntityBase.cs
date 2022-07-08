﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Nikan.Services.{ Service_Name }.SharedKernel;

// This can be modified to EntityBase<TId> to support multiple key types (e.g. Guid)
public abstract class EntityBase
{
  private readonly List<DomainEventBase> _domainEvents = new();
  public Guid Id { get; set; }

  [NotMapped] public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

  protected void RegisterDomainEvent(DomainEventBase domainEvent)
  {
    _domainEvents.Add(domainEvent);
  }

  internal void ClearDomainEvents()
  {
    _domainEvents.Clear();
  }
}
