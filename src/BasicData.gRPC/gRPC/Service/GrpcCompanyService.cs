using AutoMapper;
using Grpc.Core;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.gRPC.gRPC.Protos;
using Nikan.Services.{ Service_Name}.SharedKernel.Interfaces;


namespace Nikan.Services.{ Service_Name }.gRPC.gRPC.Service;

public class GrpcCompanyService : GrpcCompany.GrpcCompanyBase
{
  private readonly IRepository<Company> _repository;
  private readonly IMapper _mapper;
  private readonly ILogger<GrpcCompanyService> _logger;
  public GrpcCompanyService(ILogger<GrpcCompanyService> logger, IRepository<Company> repository, IMapper mapper)
  {
    _logger = logger;
    _repository = repository;
    _mapper = mapper;
  }
  public override Task<CompanyResponse> GetAllCompanies(GetAllRequest request, ServerCallContext context)
  {
    var response = new CompanyResponse();

    var companies = _repository.ListAsync().Result;


    foreach (var company in companies)
    {
      response.Message.Add(_mapper.Map<GrpcCompanyModel>(company));
    }
    return Task.FromResult(response);
  }

}
