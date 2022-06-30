using Ardalis.Specification;

namespace Nikan.Services.Template.SharedKernel.Interfaces
{
  public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
  {
  }
}