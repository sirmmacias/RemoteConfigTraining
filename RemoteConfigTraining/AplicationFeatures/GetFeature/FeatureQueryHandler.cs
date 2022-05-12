using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RemoteConfigTraining.Infrastructure;

namespace RemoteConfigTraining.Services.GetFeature;

//public class GetWarehousesQuery : IRequest<IEnumerable<Feature>>
//{
//    public string FeatureName { get; set; }
//}
public record GetFeaturesQuery(string? FeatureName) : IRequest<IEnumerable<FeatureDto>>;

public class GetFeaturesQueryHandler : IRequestHandler<GetFeaturesQuery, IEnumerable<FeatureDto>>
{
    private readonly IMapper _mapper;
    private readonly IFeatureRepository _featureRepository;
    
    public GetFeaturesQueryHandler(IMapper mapper, IFeatureRepository featureRepository)
    {
        _mapper = mapper;   
        _featureRepository = featureRepository;
    }

    public async Task<IEnumerable<FeatureDto>> Handle(GetFeaturesQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<FeatureDto> query =  _mapper.Map<List<FeatureDto>>(_featureRepository.Get(request.FeatureName));

        return query.ToList();
    }
}