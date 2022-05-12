using Microsoft.EntityFrameworkCore;
using RemoteConfigTraining.Domain;

namespace RemoteConfigTraining.Infrastructure
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly ApiContext _dbContext;
        public FeatureRepository(ApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Feature feature)
        {
            _dbContext.Features.Add(feature);
            _dbContext.SaveChanges();
            return feature.Id;
        }

        public IEnumerable<Feature> Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _dbContext.Features.AsNoTracking();
            }

            return _dbContext.Features.Where(w => w.Key.Equals(name)).AsNoTracking();
        }

        public void Remove(Feature feature)
        {
            _dbContext.Features.Remove(feature);
            _dbContext.SaveChanges();
        }
    }
}
