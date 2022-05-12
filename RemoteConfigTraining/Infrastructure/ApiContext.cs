using Microsoft.EntityFrameworkCore;
using RemoteConfigTraining.Domain;

namespace RemoteConfigTraining.Infrastructure
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Feature> Features { get; set; }

    }
}
