using Ardalis.Specification;

namespace Nikan.Services.Template.SharedKernel.Interfaces
{
  // from Ardalis.Specification
  public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
  {
  }
}