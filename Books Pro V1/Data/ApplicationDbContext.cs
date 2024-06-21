using Microsoft.EntityFrameworkCore;
using Books_Pro_V1.Models;


    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        { 
        }
        public DbSet<Books> Books { get; set; }
    }

