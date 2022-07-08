namespace Nikan.Services.{ Service_Name }.SharedKernel.Pagination;

public interface ISortHelper<T>
{
  IQueryable<T> ApplySort(IQueryable<T> entities, string orderByQueryString);
}
