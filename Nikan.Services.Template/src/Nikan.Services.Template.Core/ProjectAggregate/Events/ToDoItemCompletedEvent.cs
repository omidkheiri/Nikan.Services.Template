using Nikan.Services.Template.SharedKernel;

namespace Nikan.Services.Template.Core.ProjectAggregate.Events
{
  public class ToDoItemCompletedEvent : DomainEventBase
  {
    public ToDoItem CompletedItem { get; set; }

    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
      CompletedItem = completedItem;
    }
  }
}