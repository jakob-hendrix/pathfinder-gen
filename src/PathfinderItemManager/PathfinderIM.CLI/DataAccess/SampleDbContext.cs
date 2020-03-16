using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PathfinderIM.CLI.DataAccess.Models;

namespace PathfinderIM.CLI.DataAccess
{
    public class SampleDbContext : DbContext
    {
        private readonly IConfiguration _config;
        private readonly ILogger<SampleDbContext> _logger;

        public SampleDbContext(IConfiguration config, ILogger<SampleDbContext> logger, DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
            _config = config;
            _logger = logger;
        }

        public DbSet<SampleEntity> SampleEntities { get; set; } 
    }
}
