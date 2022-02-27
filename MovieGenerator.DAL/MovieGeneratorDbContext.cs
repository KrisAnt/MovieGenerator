using Microsoft.EntityFrameworkCore;
using MovieGenerator.DAL.Models;

namespace MovieGenerator.DAL
{
    public class MovieGeneratorDbContext : DbContext
    {
        public MovieGeneratorDbContext(DbContextOptions<MovieGeneratorDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
