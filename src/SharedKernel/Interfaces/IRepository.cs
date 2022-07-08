using System.Linq.Expressions;
using Ardalis.Specification;
using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;

namespace Nikan.Services.{ Service_Name }.SharedKernel.Interfaces;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
  IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
}

