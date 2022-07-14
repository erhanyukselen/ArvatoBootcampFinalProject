using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres
        {
            get; set;
        }
        public DbSet<MovieEntities> Movies
        {
            get; set;
        }

        public MovieContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Database=FinalProject;Port=5432;User Id=postgres;Password=123");
        }

        public DbSet<MovieEntities> tblMovie { get; set; }
        
    }
}
