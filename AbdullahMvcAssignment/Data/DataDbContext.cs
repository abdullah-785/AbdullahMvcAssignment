using AbdullahMvcAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace AbdullahMvcAssignment.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option 
        {

        }


        public DbSet<Login>  Login { get; set; }

    }
}
