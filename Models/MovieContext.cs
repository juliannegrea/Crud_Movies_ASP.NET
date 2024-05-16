using Microsoft.EntityFrameworkCore;

namespace RazorPageMovies.Models
{
    public class MovieContext : DbContext
    {
            public MovieContext(DbContextOptions<MovieContext> options)
                : base(options)
            {
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)"); // Definimos una precisión de 18 y escala de 2, ajusta esto según tus necesidades

            // Otros ajustes del modelo aquí si los tienes
        }

        // Define las propiedades DbSet para cada entidad de tu base de datos
        public DbSet<Movie> ID { get; set; }
            public DbSet<Movie> Title { get; set; }
            public DbSet<Movie> ReleaseDate { get; set; }
            public DbSet<Movie> Genre { get; set; }
            public DbSet<Movie> Price { get; set; }
      

    }
}
