using AutoMapper;
using RemoteConfigTraining.Domain;
using RemoteConfigTraining.Services;

namespace RemoteConfigTraining.MapperProfiles
{
    public class FeatureProfile : Profile
    {
        public FeatureProfile()
        {
            CreateMap<Feature, FeatureDto>();
        }
    }
}
