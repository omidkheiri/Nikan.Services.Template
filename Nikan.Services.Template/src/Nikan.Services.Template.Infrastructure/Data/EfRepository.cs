using Ardalis.Specification.EntityFrameworkCore;
using Nikan.Services.Template.SharedKernel.Interfaces;

namespace Nikan.Services.Template.Infrastructure.Data
{
  // inherit from Ardalis.Specification type
  public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
  {
    public EfRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
  }
}