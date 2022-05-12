using RemoteConfigTraining.Domain;

namespace RemoteConfigTraining.Infrastructure
{
    public interface IFeatureRepository
    {

        int Add(Feature feature);
        IEnumerable<Feature> Get(string? name);
        void Remove(Feature feature);
    }
}
