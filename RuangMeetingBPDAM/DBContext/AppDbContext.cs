using Microsoft.EntityFrameworkCore;
using RuangMeetingBPDAM.Models;

namespace RuangMeetingBPDAM.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Facilities> Facilities { get; set; }
    }
}
