using Microsoft.EntityFrameworkCore;

namespace DescribeForm.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
    public DbSet<Describe> Describes {  get; set; }
    }
}
