using BibliotecaLibrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaLibrosAPI.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Libro> Libro {  get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}
