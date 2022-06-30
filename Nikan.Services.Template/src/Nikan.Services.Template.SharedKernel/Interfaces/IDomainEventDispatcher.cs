
namespace Nikan.Services.Template.SharedKernel.Interfaces
{
  public interface IDomainEventDispatcher
  {
    Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents);
  }
}