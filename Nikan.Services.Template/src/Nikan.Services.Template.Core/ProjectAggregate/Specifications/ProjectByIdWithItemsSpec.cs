using Ardalis.Specification;
using Nikan.Services.Template.Core.ProjectAggregate;

namespace Nikan.Services.Template.Core.ProjectAggregate.Specifications
{
  public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
  {
    public ProjectByIdWithItemsSpec(int projectId)
    {
      Query
          .Where(project => project.Id == projectId)
          .Include(project => project.Items);
    }
  }
}