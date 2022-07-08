using AutoMapper;
using Grpc.Core;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.WebApi.V1.gPRC.Protos;
using Nikan.Services.{ Service_Name}.SharedKernel.Interfaces;


namespace Nikan.Services.{ Service_Name }.WebApi.V1.gPRC.Service;

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
  public override Task<CompanyResponse> GetCompanyById(GetCopmanyRequest request, ServerCallContext context)
  {
    var response = new CompanyResponse();

    var company = _repository.GetByIdAsync(Guid.Parse(request.CompanyId)).Result;



    response.Message.Add(_mapper.Map<GrpcCompanyModel>(company));

    return Task.FromResult(response);
  }

}
