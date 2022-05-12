using MediatR;
using RemoteConfigTraining.Domain;
using RemoteConfigTraining.Infrastructure;

namespace RemoteConfigTraining.Services.PostFeature;

//public class FeatureCommandHandler : IRequest<int>
//{
//        public Feature Model { get; }
//        public FeatureCommandHandler(Feature model)
//        {
//            this.Model = model;
//        }

//}

public record PostFeaturesCommand(FeatureCommand model) : IRequest<int>;


public class PostFeaturesCommandHandler
        : IRequestHandler<PostFeaturesCommand, int>
{

    private IFeatureRepository _featureRepository;  

    public PostFeaturesCommandHandler(IFeatureRepository featureRepository)
    {
        _featureRepository = featureRepository; 
    }

    public async Task<int> Handle(
        PostFeaturesCommand request, CancellationToken cancellationToken)
    {

        Feature f = new Feature{
            Key = request.model.Key,
            Value = request.model.Value
        };

        return _featureRepository.Add(f);
    }
}
