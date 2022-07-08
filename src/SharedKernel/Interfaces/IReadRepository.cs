using Ardalis.Specification;

namespace Nikan.Services.{ Service_Name }.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
