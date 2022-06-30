using MediatR;

namespace Nikan.Services.Template.SharedKernel
{
  public abstract class DomainEventBase : INotification
  {
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
  }
}