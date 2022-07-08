using MediatR;

namespace Nikan.Services.{ Service_Name }.SharedKernel;

public abstract class DomainEventBase : INotification
{
  public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
