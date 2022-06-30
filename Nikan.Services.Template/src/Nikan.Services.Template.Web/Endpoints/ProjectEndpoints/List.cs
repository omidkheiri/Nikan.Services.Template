using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Nikan.Services.Template.Core.ProjectAggregate;
using Nikan.Services.Template.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace Nikan.Services.Template.Web.Endpoints.ProjectEndpoints
{
  public class List : EndpointBaseAsync
      .WithoutRequest
      .WithActionResult<ProjectListResponse>
  {
    private readonly IReadRepository<Project> _repository;

    public List(IReadRepository<Project> repository)
    {
      _repository = repository;
    }

    [HttpGet("/Projects")]
    [SwaggerOperation(
        Summary = "Gets a list of all Projects",
        Description = "Gets a list of all Projects",
        OperationId = "Project.List",
        Tags = new[] { "ProjectEndpoints" })
    ]
    public override async Task<ActionResult<ProjectListResponse>> HandleAsync(CancellationToken cancellationToken)
    {
      var response = new ProjectListResponse();
      response.Projects = (await _repository.ListAsync()) // TODO: pass cancellation token
          .Select(project => new ProjectRecord(project.Id, project.Name))
          .ToList();

      return Ok(response);
    }
  }
}