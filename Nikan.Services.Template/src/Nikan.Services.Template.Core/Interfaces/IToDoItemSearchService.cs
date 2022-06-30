using Ardalis.Result;
using Nikan.Services.Template.Core.ProjectAggregate;

namespace Nikan.Services.Template.Core.Interfaces
{
  public interface IToDoItemSearchService
  {
    Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
    Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
  }
}