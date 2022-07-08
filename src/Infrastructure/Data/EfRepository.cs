using System.Linq.Expressions;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.SharedKernel.Interfaces;
using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;

namespace Nikan.Services.{ Service_Name }.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>,
  IRepository<T> where T : class, IAggregateRoot
{
  private readonly AppDbContext _appDbContext;
  private readonly ISortHelper<Company> _sortHelper;
  public EfRepository(AppDbContext appDbContext) : base(appDbContext)
  {
    _appDbContext = appDbContext;
    _sortHelper = new SortHelper<Company>();
  }


  public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
  {
    return _appDbContext.Set<T>()
      .Where(expression)
      .AsNoTracking();
  }
}
