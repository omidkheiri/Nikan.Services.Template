using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.Core.Interfaces;
using Nikan.Services.{ Service_Name}.SharedKernel.Interfaces;
using Nikan.Services.{ Service_Name}.SharedKernel.Pagination;

namespace Nikan.Services.{ Service_Name }.Core.Services;
public class SearchCompanyService : ISearchCompanyService
{
  private readonly IRepository<Company> _repository;

  public SearchCompanyService(IRepository<Company> repository)
  {
    _repository = repository;
  }




}
