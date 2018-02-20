using Microsoft.EntityFrameworkCore;

namespace HOMEWORKASP.Models
{
    public class HOMEWORKASPContext : DbContext
    {
        public HOMEWORKASPContext (DbContextOptions<HOMEWORKASPContext> options)
            : base(options)
        {
        }

        public DbSet<HOMEWORKASP.Models.Car> Car { get; set; }
        public DbSet<HOMEWORKASP.Models.Make> Make { get; set; }
    }
}