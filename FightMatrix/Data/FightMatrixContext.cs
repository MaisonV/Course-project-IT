using FightMatrix.Models;
using Microsoft.EntityFrameworkCore;

namespace FightMatrix.Data
{
    public class FightMatrixContext : DbContext
    {
        public FightMatrixContext(DbContextOptions<FightMatrixContext> options) : base(options)
        {

        }
        public DbSet<Fighter> Fighter { get; set; }
    }
}
